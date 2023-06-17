using System;
using System.Collections.Generic;

namespace Oef1
{
    internal class Stapel<sTpel>
    {

        private List<sTpel> Stapellijst = new List<sTpel>();
        private List<sTpel> stapellijstCopy = new List<sTpel>();


        public void toevoegenStapel(sTpel toeTeVoegen)
        {
            Stapellijst.Add(toeTeVoegen);
        }

        public sTpel AddinStapel()
        {
            if (Stapellijst.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            sTpel updatedLijst = Stapellijst[Stapellijst.Count - 1];
            Stapellijst.RemoveAt(Stapellijst.Count - 1);

            return updatedLijst;
        }

        public void StapelLeegMaken()
        {
            Stapellijst.Clear();
        }


        public bool IsAanwezigOpStapel(sTpel tezoeken)
        {
            foreach (sTpel elements in Stapellijst)
            {

                if (elements.ToString() == tezoeken.ToString())
                {

                    return true;

                }

            }

            return false;

        }

        public override string ToString()
        {
            string lijst = "";

            foreach (sTpel t in Stapellijst)
            {
                lijst += t.ToString() + " " + ",";
            }

            return lijst;
        }

        public List<sTpel> StapelCopy()
        {
            stapellijstCopy = Stapellijst.GetRange(0, Stapellijst.Count);

            return stapellijstCopy;
        }

    }
}
