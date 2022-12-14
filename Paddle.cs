namespace BlockBreaker
{
    internal class Paddle
    {
        //(===========)
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Length { get; private set; }
        public string[] Parts { get; }
        private readonly Canvas _canvas;

        public Paddle(Canvas canvas)
        {
            _canvas = canvas;
            Length = 10;
            Parts = new string[Length];
            X = (_canvas.X - Length / 2) + _canvas.Width / 2;
            Y = _canvas.Height + _canvas.Y - 2;
        }


        public void Show()
        {
            for (int i = 0; i < Length; i++)
            {
                Helper.PrintAtPosition(X + i, Y, '═');
                Helper.PrintAtPosition(X + i, Y + 1, '═');

            }
        }

        public void MoveRight()
        {
            int endPos = X + Length;
            if (endPos < _canvas.Width + _canvas.X)
            {
                X++;
                Helper.PrintAtPosition(X - 1, Y, ' ');
                Helper.PrintAtPosition(X - 1, Y + 1, ' ');


            }
        }

        public void MoveLeft()
        {
            if (X - 1 > _canvas.X)
            {
                X--;
                Helper.PrintAtPosition(X + Length, Y, ' ');
                Helper.PrintAtPosition(X + Length, Y + 1, ' ');


            }

        }
    }
}
