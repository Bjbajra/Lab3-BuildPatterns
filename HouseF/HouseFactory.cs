using HouseF.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class HouseFactory 
    {
        private Dictionary<string, Type> _houses;
        public HouseFactory()
        {
            _houses = BuildHouseByReflection();
        }

        public House ConstructHouse(string houseName)
        {
             return GetHouseFromDictionary(houseName.ToLower());
        }
        #region BuildHouseWithoutReflection
        /*private Dictionary<string, Type> BuildHouses()
        {
            Dictionary<string, Type> availableHouse = new Dictionary<string, Type>();
            availableHouse.Add("normal", typeof(NormalHouse));
            availableHouse.Add("garage", typeof(HouseWithGarage));
            availableHouse.Add("perfect", typeof(PerfectHouse));
            return availableHouse;
        }

        private House GetHouseFromDictionary(string houseName)
        {
            Type houseType = _houses[houseName];
            if (houseType == null)
            {
                throw new ArgumentException($"Could not find a house with type {houseName}");
            }
            return (House) Activator.CreateInstance(houseType);
        }*/
    #endregion

    private Dictionary<string, Type> BuildHouseByReflection()
        {
            IEnumerable<Type> availableTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(House)));

            Dictionary<string, Type> availableHouses = new Dictionary<string, Type>();

            foreach(Type t in availableTypes)
            {
                availableHouses.Add(t.Name.ToLower(), t);                
            }
            return availableHouses;
        }
        private House GetHouseFromDictionary(string houseName)
        {
            Type houseType = _houses[houseName];          
            return (House)Activator.CreateInstance(houseType);
        }
    }
}
