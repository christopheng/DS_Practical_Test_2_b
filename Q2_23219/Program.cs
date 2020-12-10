using System;

namespace DS_Practical_Test_2_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<Person> donation = new Tree<Person>();
            donation.Root = new BinaryNode<Person>() { Data = new Person() { Name = "Lizzy", Amount = 21 } };
            donation.Root.Children = new BinaryNode<Person>[]
            {
                new BinaryNode<Person>(){Data=new Person(){Name="James", Amount=34}, Parent=donation.Root},
                new BinaryNode<Person>(){Data=new Person(){Name="Beth", Amount=39}, Parent=donation.Root}
            };

            donation.Root.Children[0].Children = new BinaryNode<Person>[]
            {
                new BinaryNode<Person>(){Data=new Person(){Name="Tom", Amount=31}, Parent=donation.Root.Children[0]},
                new BinaryNode<Person>(){Data=new Person(){Name="Denis", Amount=9}, Parent=donation.Root.Children[0]}
            };
            donation.Root.Children[1].Children = new BinaryNode<Person>[]
            {
                new BinaryNode<Person>(){Data=new Person(){Name="Mary", Amount=23}, Parent=donation.Root.Children[1]},
                new BinaryNode<Person>(){Data=new Person(){Name="Rose", Amount=26}, Parent=donation.Root.Children[1]}
            };

            donation.Root.Children[0].Children[0].Children = new BinaryNode<Person>[]
            {
                new BinaryNode<Person>(){Data=new Person(){Name="John", Amount=8}, Parent=donation.Root.Children[0].Children[0]},
                new BinaryNode<Person>(){Data=new Person(){Name="Keith", Amount=11}, Parent=donation.Root.Children[0].Children[0]}
            };
            donation.Root.Children[0].Children[1].Children = new BinaryNode<Person>[]
            {
                new BinaryNode<Person>(){Data=new Person(){Name="Kate", Amount=14}, Parent=donation.Root.Children[0].Children[1]},
                new BinaryNode<Person>(){Data=new Person(){Name="Ben", Amount=22}, Parent=donation.Root.Children[0].Children[1]}
            };
            donation.Root.Children[1].Children[0].Children = new BinaryNode<Person>[]
            {
                new BinaryNode<Person>(){Data=new Person(){Name="Herold", Amount=21}, Parent=donation.Root.Children[1].Children[0]},
                new BinaryNode<Person>(){Data=new Person(){Name="Lily", Amount=9}, Parent=donation.Root.Children[1].Children[0]}
            };
            donation.Root.Children[1].Children[1].Children = new BinaryNode<Person>[]
            {
                new BinaryNode<Person>(){Data=new Person(){Name="Philip", Amount=2}, Parent=donation.Root.Children[1].Children[1]},
                new BinaryNode<Person>(){Data=new Person(){Name="Susan", Amount=8}, Parent=donation.Root.Children[1].Children[1]}
            };

            Console.WriteLine(BinaryNode<Person>.NodeExists(donation.Root, "Philip", out BinaryNode<Person> node));
            
            Console.WriteLine(BinaryNode<Person>.IndirectSum(node, node.Data.Amount)); 
        }
    }
}
