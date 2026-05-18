class Fraction
{
    private int _topNumber;
    private int _bottomNumber;
    public Fraction(){
        _topNumber=1;
        _bottomNumber=1;
    }
    public Fraction(int top)
    {
        _topNumber=top;
        _bottomNumber=1;
    }
    public Fraction(int top, int bottom)
    {
        _topNumber=top;
        _bottomNumber=bottom;
    }

    public void SetBottom(int bottom)
        {
            if (bottom != 0)
            {
                _bottomNumber = bottom;
            }
            else
            {
                _bottomNumber = 1;
            }
        }

        public void SetTop(int top)
        {
            _topNumber = top;
        }

        public int GetTop()
        {
            return _topNumber;
        }
        public int GetBottom()
        {
            return _bottomNumber;
        }

    public string ShowFraction()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }
    public double ShowDecimal()
    {
        return (double)_topNumber/(double)_bottomNumber;
    }
}