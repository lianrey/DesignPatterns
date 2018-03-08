## Design Patterns

### Buider1 and Builder2 project
```This 2 projects are examples of the Builder design pattern.
  - **Builder design pattern:** (Creational) This is one of my favorite patterns because it allows to create new object in a very nice way.
    Example: var economy = new CarBuilder()
                .Model("Economy")
                .Wheels(4)
                .Upholstery("Cloth")
                .Color("Black")
                .AirConditioning(false)
                .Build();
  - Note: This video: https://www.youtube.com/watch?v=9XnsOpjclUg is really helpful to understand this pattern (it's in java but the idea is exactly the same). 
```


### ChainOfResponsability and ChainOfResponsability project 
```This 2 projects are examples of the chain of responsabiity design pattern.
  - **Builder design pattern:** (Behavioral) This main idea of this pattern is every time you request something from one class and that class can't handle it, it send the request to some other class that my handle the request.
  Example: 
    public interface Chain
    {
        void SetNextChain(Chain nextChain);
        void Withdraw(int quantity);
    }
    public class BankManager: Chain
    {
        private Chain nextChain;

        public void SetNextChain(Chain nextChain)
        {
            this.nextChain = nextChain;
        }

        public void Withdraw(int quantity)
        {
            ...
        }
    }
  - Note: This video: https://www.youtube.com/watch?v=jDX6x8qmjbA is really helpful to understand this pattern (it's in java but the idea is exactly the same). 
```
