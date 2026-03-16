using indiano;

Professor prof = new Professor();
Console.WriteLine("insira o nome");
prof.nome = Console.ReadLine();
Console.WriteLine("Insira a idade");
prof.idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira o CPF");
prof.cpf = Console.ReadLine();

prof.listardados(prof.nome, prof.idade, prof.cpf);

//Parte do Aluno
Console.WriteLine();

Aluno AL = new Aluno();
Console.WriteLine("Digite o RM do Aluno");
AL.RM = Console.ReadLine();
Console.WriteLine("Digite o curso do Aluno");
AL.curso = Console.ReadLine();

AL.ListarAluno(AL.RM, AL.curso);


   
