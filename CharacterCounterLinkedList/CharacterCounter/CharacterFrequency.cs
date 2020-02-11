using System;

namespace CharacterCounter
{
    public class CharacterFrequency
    {
        public Char Character { get; set; }

        public Int32 Frequency { get; set; }

        public CharacterFrequency ()
        {
            Frequency = 0;
        }

        public void Increment()
        {
            Frequency++;
        }

        public override Boolean Equals(Object character)
        {
            // Check if the character is null or is not the same type
            if (character == null || !(character.GetType() == GetType()))
            {
                return false;
            }

            // Check if the Object is this instance
            if (character == this)
            {
                return true;
            }

            // Cast the Object to the CharacterFrequency class
            CharacterFrequency instance = (CharacterFrequency) character;

            return Character == instance.Character;
        }

        public override String ToString()
        {
            return Character.ToString();
        }
        
        public override Int32 GetHashCode()
        {
            return (Int32) Character;
        }
    }
}