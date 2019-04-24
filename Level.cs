using System;

namespace Tower_Defense
{

    class Level
    {
        private readonly Invader[] _invaders;
        public Tower [] Towers {get; set;}

        public Level (Invader[] invaders)
        {
            _invaders = invaders;
        }

        //returns true if player wins
        public bool Play()
        {
            //run until all invaders die or invader reaches end
            int remainingInvaders = _invaders.Length;
            while (remainingInvaders > 0)
            {
            //Each tower has a chance to fire on invaders
            foreach (Tower tower in Towers)
            {
                tower.FireOnInvaders(_invaders);
            }
            //count and move invaders that are still active
             remainingInvaders = 0;
             foreach (Invader invader in _invaders)
             {
                 if (invader.IsActive)
                 {
                     invader.Move();
                     if (invader.HasScored)
                     {
                         return false;
                     }
                     remainingInvaders++;
                 }
             }   
            }

            return true; 
        }
    }
    
}