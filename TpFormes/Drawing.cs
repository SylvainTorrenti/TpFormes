using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormes
{
    internal class Drawing
    {
        #region Props
        /// <summary>
        /// Liste des formes
        /// </summary>
        private List<Form> _forms = new List<Form>(); 
        #endregion
        #region Methode
        /// <summary>
        /// Affiche la lsite des fomes
        /// </summary>
        public void AfficherLaListeDeForme()
        {
            Console.WriteLine("La liste des formes est :");
            for (int i = 0; i < _forms.Count; i++)
            {
                Console.WriteLine($"{_forms.ElementAt(i)}");
            }
        }
        /// <summary>
        /// Ajoute une forme
        /// </summary>
        /// <param name="form"></param>
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
        /// <summary>
        /// Range la liste
        /// </summary>
        public void SortList()
        {
            _forms.Sort();
        } 
        #endregion

    }
}
