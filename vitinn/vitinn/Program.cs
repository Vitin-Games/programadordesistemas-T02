Console.WriteLine("Selecione o metodo de pagamento:");
Console.WriteLine(" 1 - Pix/QR code ");
Console.WriteLine(" 2 - Débito/Voucher ");
Console.WriteLine(" 3 - Crédito ");
string pergunta;
pergunta = Console.ReadLine();
switch (int.Parse(pergunta))
{
    default:
        Console.WriteLine(" Opção invalida" );
        break;
    case 1:
        Console.WriteLine(" Pix/QR code Selecionado ");
        break;
    case 2:
        Console.WriteLine(" Débito/Voucher Selecionado ");
        break;
    case 3:
        Console.WriteLine(" Crédito Selecionado ");
        break;
}