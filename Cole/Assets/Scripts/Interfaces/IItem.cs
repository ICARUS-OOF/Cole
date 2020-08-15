using UnityEngine;
namespace Cole
{
    namespace Interfaces
    {
        public interface IItem
        {
            string _name { get; set; }
            int price { get; set; }
        }
    }
}