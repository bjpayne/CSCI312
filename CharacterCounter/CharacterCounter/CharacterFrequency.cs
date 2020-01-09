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

        public Boolean Equals(Char character)
        {
            return character.Equals(Character);
        }

        public override String ToString()
        {
            return Character.ToString();
        }
    }
}