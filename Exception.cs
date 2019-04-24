namespace Tower_Defense
{

        class TowerDefenseException : System.Exception
        {

            public TowerDefenseException()
            {
                
            }
            public TowerDefenseException(string message) : base(message)
            {

            }
        }

        class OutOfBoundsException : TowerDefenseException
        {

            public OutOfBoundsException()
            {

            }
            public OutOfBoundsException (string message) : base(message)
            {


            }
        }


}