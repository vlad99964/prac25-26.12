using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTablets
{
    [Serializable]
    class Tablet
    {
        private string model;
        private double diagonal;
        private string operationSystem;
        private short memory;
        private short storage;
        private string cpu;
        public Tablet()
        {
        }
        public void SetStringValues(string[] array)
        {
            model = array[0];
            diagonal = Convert.ToDouble(array[1]);
            operationSystem = array[2];
            memory = Convert.ToInt16(array[3]);
            storage = Convert.ToInt16(array[4]);
            cpu = array[5];
        }
        public string[] GetStringValues()
        {
            string[] array = new string[6]; 

            array[0] = model;
            array[1] = diagonal.ToString();
            array[2] = operationSystem;
            array[3] = memory.ToString();
            array[4] = storage.ToString();
            array[5] = cpu;
            return array; 
        }
    }

}   
