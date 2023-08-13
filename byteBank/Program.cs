using byteBank.Contas;
using byteBank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "Andre Iguodala";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da Conta do Andre = " +contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 15;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria =" + contaDaMaria.saldo);

//contaDoAndre.Transferir(75, contaDaMaria);
//Console.WriteLine(" Saldo do Andre = "+ contaDoAndre.saldo);
//Console.WriteLine(" Saldo do Maria = " + contaDaMaria.saldo);


//Cliente cliente = new Cliente();
//cliente.nome = "André Iguodala";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;


//ContaCorrente conta3 = new ContaCorrente();
//conta3.SetSaldo(10);
//Console.WriteLine(  conta3.GetSaldo());

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(133, "ZXIBIT");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(545, "DRDRE-01");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);