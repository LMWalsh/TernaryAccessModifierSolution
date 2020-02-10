using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAccessModifierProject {
    public class Customer {

        private static int NextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        private bool IsNationalAccount { get; set; }

        public void NationalAccount(string YesOrNo) {
            this.IsNationalAccount = YesOrNo.Equals("yes") ? true : false;
        }
        public Customer(string Name) {
            this.Id = NextId;
            this.Name = Name;
            NextId++;
        }
    }
}
