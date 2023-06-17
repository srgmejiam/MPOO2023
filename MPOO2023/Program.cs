using BLL;
using EL;

static void main()
{
    Cliente cliente = new();

    Console.WriteLine("Ingrese su nombre");
    cliente.Nombre = Console.ReadLine();
    cliente.IdCliente = 1;
    BLL_Cliente.InsertCliente(cliente);


    foreach (var client in BLL_Cliente.GetClientes())
    {
        Console.WriteLine(client.IdCliente + " - " + client.Nombre);
    }
    Console.ReadLine();


}
main();



