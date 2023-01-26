using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Drawing
    {
        private List<Form> _forms = new List<Form>();

        public void AfficherLaListeDeForme()
        {
            Console.WriteLine("La liste des formes est :");
            for (int i = 0; i < _forms.Count; i++)
            {
                Console.WriteLine($"{_forms.ElementAt(i).GetSurface()}");
            }
        }
        public void AddForm(Form form)
        {
            if (_forms.Contains(form))
            {
                Console.WriteLine("Cette forme est déjà présente dans la collection !");
            }
            else
            {
                _forms.Add(form);
                Console.WriteLine($"La forme est maintenant disponible dans votre liste.");
            }
        }
        public void SortList()
        {
            _forms.Sort();
        }

    }
}
