using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryMethod1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Month: ");
            int month = int.Parse(Console.ReadLine());

            AvocadoFactory factory = new AvocadoFactory(new AvocadoImport[] { new SouthAfricaAvocado(), new SpainAvocado() });
            AvocadoImport import = factory.Create(month);

            Console.WriteLine("Country: " + import.Origin);
            var x = new int[] { };
        }
    }

    public class Injector
    {
        private readonly Dictionary<Type, Func<object>> providers = new Dictionary<Type, Func<object>>();

        public void Bind<TKey, TConcrete>() where TConcrete : TKey {
            providers[typeof(TKey)] = () => ResolveByType(typeof(TConcrete));
        }

        private object ResolveByType(Type type) {
            var constructor = type.GetConstructors().SingleOrDefault();
            if (constructor != null) {
                var arguments = constructor.GetParameters()
                                           .Select(p => Resolve(p.ParameterType))
                                           .ToArray();
                return constructor.Invoke(arguments);
            }
            var instanceField = type.GetField("Instance"); // He did this because there is a field in one of his classes that is called "Instance" 
            return instanceField.GetValue(null);
        }

        public void Bind<T>(T instance) {
            providers[typeof(T)] = () => instance;
        }

        public TKey Resolve<TKey>() {
            return (TKey)Resolve(typeof(TKey));
        }

        public object Resolve(Type type) {
            Func<object> provider;
            if (providers.TryGetValue(type, out provider)) {
                return provider();
            }
            return ResolveByType(type);
        }
    } 
}
