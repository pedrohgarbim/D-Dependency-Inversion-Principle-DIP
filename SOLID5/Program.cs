using SOLID5.WITH_DIP;

// Dependency Inversion Principle (DIP)
//Módulos de alto nível não devem depender de módulos de baixo nível;
//ambos devem depender de abstrações. Além disso, abstrações não devem
//depender de detalhes.



// Violação de princio: ReportGenerator depende diretamente de uma
// implementação concreta PDFReport, o que dificulta a troca de tipos de relatórios.



Console.WriteLine("Relatório PDF gerado.");

// isso gera o problema de:  Se quisermos gerar um relatório em outro formato,
// precisamos modificar a classe ReportGenerator, o que viola o DIP.



// Se for necessario gerar um relatorio em outro formato, sera necessario modificar
// a classe ReportGenerator, o que viola o DIP.


// Para respeitar o princio DIP 
// ReportGenerator depende de uma abstração (interface IReport)
// em vez de uma implementação concreta.


IReport pdfReport = new PDFReport();
ReportGenerator generator = new ReportGenerator(pdfReport);
generator.Generate();



// Agora, é possível trocar a implementação de IReport sem modificar
// a classe ReportGenerator, respeitando o DIP.

