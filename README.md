##Design Patterns

#Buider1 and Builder2 project
This 2 project are example of the Builder design pattern.
  - *Builder design pattern:* (Creational) This is one of my favorite patterns because it allows to create new object in a very nice way.
    Example: var economy = new CarBuilder()
                .Model("Economy")
                .Wheels(4)
                .Upholstery("Cloth")
                .Color("Black")
                .AirConditioning(false)
                .Build();
  - 
