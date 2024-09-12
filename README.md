# 🧩 Dependency Inversion Principle (DIP)
![image](https://github.com/user-attachments/assets/669c466d-5dd1-43a7-8986-f54e6d2134c4)


## O que é o DIP?

O **Princípio da Inversão de Dependência (DIP)** diz que **módulos de alto nível não devem depender de módulos de baixo nível** 🔄. Ambos devem depender de abstrações 🧩. Além disso, **abstrações não devem depender de detalhes**; os detalhes devem depender das abstrações. Isso reduz o acoplamento entre os módulos e torna o sistema mais flexível. 🚀

### 🚨 Problema comum:

Imagine que você tenha uma classe `ReportGenerator` 📄 que depende diretamente de uma classe `PDFReport` 📑. Se quisermos gerar um relatório em outro formato, como Excel 🗂️, precisaríamos modificar `ReportGenerator`, o que aumenta o acoplamento entre as classes e torna o sistema rígido e difícil de escalar. Isso viola o DIP.

### ✅ Solução com DIP:

Para resolver isso, criamos uma abstração, como uma interface `IReport` 📊, que define o comportamento de um relatório. Agora, `ReportGenerator` depende dessa abstração em vez de depender diretamente de uma implementação concreta, como `PDFReport`.

### 🛠️ Explicação do Projeto:

No projeto que implementa o DIP:
- Criamos a interface `IReport` 📊, que define o comportamento geral de um relatório.
- Implementamos essa interface em classes como `PDFReport` 📑 e `ExcelReport` 🗂️.
- A classe `ReportGenerator` 📄 depende apenas da interface `IReport`, e não de implementações específicas.

#### 🎯 Benefícios:
- **Baixo acoplamento**: Módulos de alto nível não dependem mais diretamente de detalhes de implementação. 🔗
- **Flexibilidade**: Podemos trocar a implementação de `IReport` facilmente, por exemplo, para gerar relatórios em Excel 🗂️ em vez de PDF, sem modificar o código de `ReportGenerator`. 🚀
- **Facilidade de manutenção**: O sistema se torna mais fácil de modificar e manter, já que as dependências são claras e controladas. 🛠️ 
## Estrutura do Projeto
![image](https://github.com/user-attachments/assets/89bb2fba-9192-4982-a01f-f3608a47d0cc)
