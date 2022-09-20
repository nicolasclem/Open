// leccion 3
using System.Reflection.Metadata.Ecma335;

Client Pepe = new Client("Nicolas",541100000,"colon 800","nicolas@test.com",false);

Console.WriteLine(Pepe);


Console.WriteLine(Pepe.FullName);

Console.WriteLine(Pepe.Phone);
Console.WriteLine(Pepe.Address);
Console.WriteLine(Pepe.Email);
Console.WriteLine(Pepe.NewClient);


Client Pipi = Pepe with { FullName = "Bauti" };
Console.WriteLine("===============*PIPI*====================");
Console.WriteLine(Pipi);    

public struct Client
{
    public Client (string? fullName,int phone , string? address, string? email,bool newClient)
    {
        FullName = fullName;
        Phone = phone;
        Address = address;
        Email = email;
        NewClient = newClient;

    }

    public string FullName { get; set; }
    public int Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }

    public bool NewClient { get; set; }

    public override string ToString() => $"Nombre Completo: {FullName} telefono:  {Phone} Direccion: {Address} Email:{Email} Cliente nuevo: {NewClient}";
    

}

