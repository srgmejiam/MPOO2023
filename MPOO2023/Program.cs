using BLL;

static void main()
{
	foreach (var item in BLL_Roles.Listar(false))
	{
		Console.WriteLine(item.IdRol+ " " + item.Rol);
	}



}

main();