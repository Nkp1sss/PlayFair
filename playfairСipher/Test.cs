using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using playfairСipher;

namespace test
{
    public class Test
    {
        public static void Main()
        {
            Test test = new Test();
            test.PlayFair_EncryptTest();
            test.PlayFair_DecryptTest();
        }

        readonly SecurityAlgorithm _target;

        public Test()
        {
            _target = new PlayFair("playfairexample");
        }

        public void PlayFair_EncryptTest()
        {
            //Arrange
            string plain = "mynameisnikita"; 
            //string cypher = "bmodzbxdnabekudmuixmmouvif";

            //Act
            string actual = _target.Encrypt(plain);
            Console.WriteLine(actual);
        }

        public void PlayFair_DecryptTest()
        {
            //Arrange
            //string plain = "hidethegoldinthetrexestump";
            string cypher = "xfolixmkkrtbvp";

            //Act
            string actual = _target.Decrypt(cypher);
            Console.WriteLine(actual);
        }
    }
}