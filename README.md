# Aprendendo trabalhar com strings em CSharp

### Guids

Guids é um gerador de indentificador unico, podemos criar uma cadeia unica de valores unicos.

```
  var id = Guid.NewGuid();
  Console.WriteLine(id.ToString().Substring(2, 8));
```

No código acima temmos o ToString() que transforma esse valor para string e o Substring()
para defimir quantos caracteres quer pegar dessa cadeia, nesse caso irá pegar do segundo
até o caractere de posição 8
