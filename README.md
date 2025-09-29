# 🎰 Loteria em C# com Vetores

Este projeto simula uma **loteria simples** utilizando a linguagem **C#** e o conceito de **vetores**.  

O jogador faz uma **aposta de 6 números distintos (1 a 60)**, o programa realiza um **sorteio aleatório de 6 números** e compara os resultados, mostrando **quantos acertos** o jogador teve.  

---

## 📌 Funcionalidades
- Permite que o jogador insira **6 números únicos**.  
- Realiza um **sorteio aleatório sem repetições**.  
- Exibe a aposta, o sorteio e a quantidade de acertos.  
- Mensagens personalizadas:  
  - 🏆 **6 acertos:** ganhou na loteria!  
  - 🎉 **4 ou 5 acertos:** boa pontuação.  
  - 😢 **Menos de 4 acertos:** tente novamente.  

---

## 🛠 Tecnologias Utilizadas
- **C# (.NET 6 ou superior)**  
- **Vetores (`int[]`)**  
- **Random** para geração de números aleatórios  
- **LINQ (`Intersect`)** para comparação de vetores  

---

## 📖 Como Executar
1. Clone este repositório ou copie o código para um projeto **Console App em C#**.  
2. Compile e execute:  

```bash
dotnet run
