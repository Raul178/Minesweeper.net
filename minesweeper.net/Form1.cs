using minesweeper.net.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace minesweeper.net
{
    public partial class Form1 : Form
    {
        bool ignore = false;
        int Mines;
        Point previousPosition;
        Size BaseSize;
        State[,] GameTableArray;
        State[,] GameTableArrayVisible;
        Bitmap[] numbers;
        Bitmap temp;
        Bitmap[] Buttons;
        int counter = 0;
        bool MainBtnMouseDown = false;
        bool mouseDown = false;

        enum State { Empty, _1, _2, _3, _4, _5, _6, _7, _8, QuestionClicked, Mine, NotMine, MineClicked, Question, Flag, Normal };
        enum Faces { Happy, Wow, Sad, Win, HappyClicked };

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDisplay(TimerDisplay, ++counter);
        }

        void LoadDisplay(PictureBox Display, int number)
        {
            if (number < 1000)
            {
                if (number >= 100)
                {
                    editDigit(Display, number / 100, 1);
                    editDigit(Display, number % 10, 3);
                    editDigit(Display, number % 100 / 10, 2);
                }
                else if (number >= 10)
                {
                    editDigit(Display, number % 10, 3);
                    editDigit(Display, number / 10, 2);
                }
                else if (number >= 0)
                {
                    editDigit(Display, number, 3);
                }
                else if (number < 0)
                {
                    editDigit(Display, 11, 1);
                    LoadDisplay(Display, Math.Abs(number % 100));
                }
                Display.Refresh();
            }
        }

        Bitmap Face(Faces buttonstate)
        {
            Bitmap equivalentBitmap = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(equivalentBitmap))
                g.DrawImage(Resources.faces, new Rectangle(0, 0, 24, 24), new Rectangle(0, 96 - ((int)buttonstate * 24), 24, 24), GraphicsUnit.Pixel);
            return equivalentBitmap;
        }

        void editDigit(object Display, int number, int digit)
        {
            FastGraphicsOver((Bitmap)(Display as PictureBox).Image, (digit - 1) * 13, 0, numbers[number]);
        }

        void changeDim(int height, int width)
        {
            GameTableArrayVisible = new State[width, height];
            GameTableArray = new State[width, height];
            Bitmap GameTable = new Bitmap(width * 16, height * 16);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    FastGraphicsOver(GameTable, x * 16, y * 16, Buttons[(int)State.Normal]);
                    GameTableArrayVisible[x, y] = State.Normal;
                    GameTableArray[x, y] = State.Empty;
                }
            }
            TableDisplay.Image = GameTable;
            Size = new Size((width * 16) + BaseSize.Width, (height * 16) + BaseSize.Height);
            MainBtnBorder.Location = new Point(((topright.Location.X + 55) / 2) - 11, MainBtnBorder.Location.Y);
            MainBtn.Location = new Point(MainBtnBorder.Location.X + 1, MainBtn.Location.Y);
        }

        void ResetDisplay(PictureBox Display)
        {
            Display.Image = new Bitmap(39, 23);
            for (int i = 1; i <= 3; i++)
            {
                editDigit(Display, 0, i);
            }
        }

        MenuItem getDifficulty()
        {
            if (Settings.Default.StartSize == new Size(8, 8) && Settings.Default.StartMines == 10)
            {
                return MNU_Beginner;
            }
            else if (Settings.Default.StartSize == new Size(16, 16) && Settings.Default.StartMines == 40)
            {
                return MNU_Intermediate;
            }
            else if (Settings.Default.StartSize == new Size(30, 16) && Settings.Default.StartMines == 99)
            {
                return MNU_Expert;
            }
            else
            {
                return MNU_Custom;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Buttons = new Bitmap[16];
            for (int i = 0; i < 16; i++)
            {
                Buttons[i] = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(Buttons[i]))
                    g.DrawImage(Resources.defaultButtons, new Rectangle(0, 0, 16, 16), new Rectangle(0, 240 - (i * 16), 16, 16), GraphicsUnit.Pixel);
            }

            BaseSize = new Size(Size.Width - 256, Size.Height - 256);
            numbers = new Bitmap[12];

            for (int i = 11; i >= 0; i--)
            {
                int y = 253 - (i * 23);
                numbers[i] = new Bitmap(13, 23);

                using (Graphics g = Graphics.FromImage(numbers[i]))
                    g.DrawImage(Resources.numbers, new Rectangle(0, 0, 13, 23), new Rectangle(0, y, 13, 23), GraphicsUnit.Pixel);
            }

            ResetDisplay(TimerDisplay);
            ResetDisplay(MinesDisplay);

            MenuItem current = getDifficulty();
            current.Checked = true;
            difficulty(current, Settings.Default.StartMines, Settings.Default.StartSize);
            MainBtn.Image = Face(Faces.Happy);
        }

        void HoverAction(MouseEventArgs e)
        {
            temp = new Bitmap((Bitmap)TableDisplay.Image);
            if (tablePositionValid(e))
            {
                int x = e.X / 16;
                int y = e.Y / 16;
                if (GameTableArrayVisible[x, y] == State.Normal)
                {
                    GraphicsOver((Bitmap)TableDisplay.Image, x * 16, y * 16, Buttons[(int)State.Empty]);
                }
                else if (GameTableArrayVisible[x, y] == State.Question)
                {
                    GraphicsOver((Bitmap)TableDisplay.Image, x * 16, y * 16, Buttons[(int)State.QuestionClicked]);
                }
                TableDisplay.Refresh();
            }
        }

        void MouseDownAction(MouseEventArgs e)
        {
            if (temp != null)
            {
                if (previousPosition.X != e.X / 16 || previousPosition.Y != e.Y / 16)
                {
                    TableDisplay.Image = temp;
                    TableDisplay.Refresh();
                    HoverAction(e);
                }
            }
            else
            {
                HoverAction(e);
            }
            previousPosition = new Point(e.X / 16, e.Y / 16);
        }

        void GraphicsOver(Bitmap baseImage, int x, int y, Bitmap bitmap)
        {
            FastGraphicsOver(baseImage, x, y, bitmap);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        void FastGraphicsOver(Bitmap baseImage, int x, int y, Bitmap bitmap)
        {
            using (Graphics g = Graphics.FromImage(baseImage))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.DrawImage(bitmap, x, y);
            }
        }

        private void TableDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ignore)
            {
                int x = e.X / 16;
                int y = e.Y / 16;
                if (e.Button == MouseButtons.Left)
                {
                    mouseDown = true;
                    MainBtn.Image = Face(Faces.Wow);
                    temp = new Bitmap((Bitmap)TableDisplay.Image);

                    if (GameTableArrayVisible[x, y] == State.Normal || GameTableArrayVisible[x, y] == State.Question)
                    {
                        MouseDownAction(e);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    switch (GameTableArrayVisible[x, y])
                    {
                        case State.Normal:
                            UpdateMines(--Mines);
                            GameTableArrayVisible[x, y] = State.Flag;
                            GraphicsOver((Bitmap)TableDisplay.Image, x * 16, y * 16, Buttons[(int)State.Flag]);
                            break;

                        case State.Flag:
                            UpdateMines(++Mines);
                            if (MNU_Marks.Checked)
                            {
                                GameTableArrayVisible[x, y] = State.Question;
                                GraphicsOver((Bitmap)TableDisplay.Image, x * 16, y * 16, Buttons[(int)State.Question]);
                            }
                            else
                            {
                                GameTableArrayVisible[x, y] = State.Normal;
                                GraphicsOver((Bitmap)TableDisplay.Image, x * 16, y * 16, Buttons[(int)State.Normal]);
                            }
                            break;

                        case State.Question:
                            GameTableArrayVisible[x, y] = State.Normal;
                            GraphicsOver((Bitmap)TableDisplay.Image, x * 16, y * 16, Buttons[(int)State.Normal]);
                            break;
                    }
                    TableDisplay.Refresh();
                }
            }
        }

        bool tablePositionValid(MouseEventArgs e)
        {
            return (e.X >= 0 && e.Y >= 0 && e.X < TableDisplay.Width && e.Y < TableDisplay.Height);
        }

        private void TableDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (tablePositionValid(e))
                {
                    if (GameTableArrayVisible[e.X / 16, e.Y / 16] == State.Normal || GameTableArrayVisible[e.X / 16, e.Y / 16] == State.Question)
                    {
                        MouseDownAction(e);
                    }
                    else
                    {
                        previousPosition = new Point(e.X / 16, e.Y / 16);
                        TableDisplay.Image = temp;
                        TableDisplay.Refresh();
                    }
                }
                else
                {
                    TableDisplay.Image = temp;
                    previousPosition = new Point(-1, -1);
                    TableDisplay.Refresh();
                }
            }
        }

        void CheckVictory()
        {
            int cnt = 0;
            int cnt2 = 0;
            foreach (var element in GameTableArrayVisible)
            {
                if (element == State.Flag || element == State.Normal)
                    cnt++;
            }
            foreach (var element in GameTableArrayVisible)
            {
                if (element == State.Question)
                    cnt2++;
            }
            if (cnt == Settings.Default.StartMines && cnt2 == 0)
            {
                timer1.Enabled = false;
                MainBtn.Image = Face(Faces.Win);
                ignore = true;

                Bitmap act = (Bitmap)TableDisplay.Image;
                for (int x = 0; x < Settings.Default.StartSize.Width; x++)
                {
                    for (int y = 0; y < Settings.Default.StartSize.Height; y++)
                    {
                        if (GameTableArrayVisible[x, y] == State.Normal)
                        {
                            GameTableArrayVisible[x, y] = State.Flag;
                            FastGraphicsOver(act, x * 16, y * 16, Buttons[(int)State.Flag]);
                        }
                    }
                }
                TableDisplay.Refresh();
            }
        }

        private void TableDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ignore)
            {
                Bitmap act = (Bitmap)TableDisplay.Image;
                int x = e.X / 16, y = e.Y / 16;
                mouseDown = false;
                if (e.Button == MouseButtons.Left)
                {
                    if (e.X >= 0 && e.Y >= 0 && e.X < TableDisplay.Image.Size.Width && e.Y < TableDisplay.Image.Size.Height)
                    {
                        if (GameTableArray[x, y] == State.Mine)
                        {
                            timer1.Enabled = false;
                            FastGraphicsOver(act, x * 16, y * 16, Buttons[(int)State.MineClicked]);
                            TableDisplay.Refresh();
                            MainBtn.Image = Face(Faces.Sad);
                            ignore = true;
                            for (int y2 = 0; y2 < Settings.Default.StartSize.Height; y2++)
                            {
                                for (int x2 = 0; x2 < Settings.Default.StartSize.Width; x2++)
                                {
                                    if (GameTableArray[x2, y2] == State.Mine && GameTableArrayVisible[x2, y2] != State.Flag)
                                    {
                                        GraphicsOver(act, x2 * 16, y2 * 16, Buttons[(int)State.Mine]);
                                    }
                                    else if (GameTableArray[x2, y2] != State.Mine && GameTableArrayVisible[x2, y2] == State.Flag)
                                    {
                                        FastGraphicsOver(act, x2 * 16, y2 * 16, Buttons[(int)State.NotMine]);
                                    }
                                }
                            }
                            GraphicsOver(act, x * 16, y * 16, Buttons[(int)State.MineClicked]);
                        }
                        else
                        {
                            if (!timer1.Enabled)
                            {
                                timer1.Enabled = true;
                            }
                            MainBtn.Image = Face(Faces.Happy);
                            GameTableArrayVisible[x, y] = State.Empty;
                            FastGraphicsOver(act, x * 16, y * 16, Buttons[(int)GameTableArray[x, y]]);
                            freeSpace(new Point(x, y), new Size(Settings.Default.StartSize.Width, Settings.Default.StartSize.Height));
                        }
                        TableDisplay.Refresh();
                        CheckVictory();
                    }
                    else
                    {
                        MainBtn.Image = Face(Faces.Happy);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (e.X >= 0 && e.Y >= 0 && e.X < TableDisplay.Image.Size.Width && e.Y < TableDisplay.Image.Size.Height)
                    {
                        CheckVictory();
                    }
                }
            }
        }

        private void ToCheck_Click(object sender, EventArgs e)
        {
            (sender as MenuItem).Checked = !(sender as MenuItem).Checked;
        }

        private void MNU_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        void UpdateMines(int mines)
        {
            Mines = mines;
            ResetDisplay(MinesDisplay);
            LoadDisplay(MinesDisplay, mines);
        }

        void difficulty(object sender, int Mines, Size size)
        {
            ignore = false;
            Random random = new Random();
            timer1.Enabled = false;
            ResetDisplay(TimerDisplay);
            TimerDisplay.Refresh();
            MNU_Beginner.Checked = false;
            MNU_Intermediate.Checked = false;
            MNU_Expert.Checked = false;
            MNU_Custom.Checked = false;
            UpdateMines(Mines);
            ((MenuItem)sender).Checked = true;
            changeDim(size.Height, size.Width);
            Settings.Default.StartSize = size;
            Settings.Default.StartMines = Mines;
            Settings.Default.Save();
            counter = 0;
            for (int y = 0; y < size.Height; y++)
            {
                for (int x = 0; x < size.Width; x++)
                {
                    GameTableArray[x, y] = State.Empty;
                }
            }

            for (int i = 0; i < Settings.Default.StartMines; i++)
            {
                int x, y;
                do
                {
                    y = 0;
                    x = random.Next(0, (size.Height * size.Width) - 1);
                    while (x >= size.Width)
                    {
                        y++;
                        x -= size.Width;
                    }
                } while (GameTableArray[x, y] == State.Mine);
                GameTableArray[x, y] = State.Mine;
            }

            for (int y = 0; y < size.Height; y++)
            {
                for (int x = 0; x < size.Width; x++)
                {
                    if (GameTableArray[x, y] != State.Mine)
                    {
                        GameTableArray[x, y] = (State)placeNumber(new Point(x, y), size);
                    }
                }
            }
        }

        int placeNumber(Point point, Size size)
        {
            int cnt = 0;
            for (int x = point.X - 1; x <= point.X + 1; x++)
            {
                for (int y = point.Y - 1; y <= point.Y + 1; y++)
                {
                    if ((y != point.Y || x != point.X) && (x >= 0 && y >= 0 && x < size.Width && y < size.Height) && GameTableArray[x, y] == State.Mine)
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
        }

        private void MNU_Beginner_Click(object sender, EventArgs e)
        {
            difficulty(sender, 10, new Size(8, 8));
        }

        private void MNU_Intermediate_Click(object sender, EventArgs e)
        {
            difficulty(sender, 40, new Size(16, 16));
        }

        private void MNU_Expert_Click(object sender, EventArgs e)
        {
            difficulty(sender, 99, new Size(30, 16));
        }

        private void MNU_Custom_Click(object sender, EventArgs e)
        {
            Custom customdialog = new Custom();
            customdialog.localLocation = topleft.PointToScreen(Point.Empty);
            if (customdialog.ShowDialog() == DialogResult.OK)
            {
                difficulty(sender, Settings.Default.StartMines, Settings.Default.StartSize);
            }
        }

        private void MNU_New_Click(object sender, EventArgs e)
        {
            difficulty(getDifficulty(), Settings.Default.StartMines, Settings.Default.StartSize);
        }

        private void MainBtn_MouseDown(object sender, MouseEventArgs e)
        {
            MainBtnMouseDown = true;
            if (e.X >= 0 && e.Y >= 0 && e.X <= 24 && e.Y <= 24)
            {
                MainBtn.Image = Face(Faces.HappyClicked);
            }
        }

        void freeSpace(Point point, Size size)
        {
            FastGraphicsOver((Bitmap)TableDisplay.Image, point.X * 16, point.Y * 16, Buttons[(int)GameTableArray[point.X, point.Y]]);

            GameTableArrayVisible[point.X, point.Y] = State.Empty;
            if (GameTableArray[point.X, point.Y] == State.Empty)
            {
                for (int x = point.X - 1; x <= point.X + 1; x++)
                {
                    for (int y = point.Y - 1; y <= point.Y + 1; y++)
                    {
                        if ((y != point.Y || x != point.X) && (x >= 0 && y >= 0 && x < size.Width && y < size.Height) && (GameTableArray[x, y] >= State.Empty && GameTableArray[x, y] <= (State)8) && GameTableArrayVisible[x, y] != State.Empty)
                        {
                            freeSpace(new Point(x, y), size);
                        }
                    }
                }
            }
        }
        private void MainBtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainBtnMouseDown)
            {
                MainBtn.Image = (e.X >= 0 && e.Y >= 0 && e.X < 24 && e.Y < 24) ? Face(Faces.HappyClicked) : Face(Faces.Happy);
            }
        }

        private void MainBtn_MouseUp(object sender, MouseEventArgs e)
        {
            MainBtnMouseDown = false;
            if (e.X < 24 && e.Y < 24)
            {
                MainBtn.Image = Face(Faces.Happy);
                difficulty(getDifficulty(), Settings.Default.StartMines, Settings.Default.StartSize);
            }
        }
    }
}
