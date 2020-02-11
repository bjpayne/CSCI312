using System;

namespace CharacterCounter
{
    public class CharacterFrequency : Object
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
            return character.Equals(Character);
        }

        public override String ToString()
        {
            return Character.ToString();
        }
    }
}