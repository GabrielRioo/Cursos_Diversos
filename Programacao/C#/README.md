# PROGRAMAÇÃO C#

### Funções
**Local   Tipo Retorno Nome (Paramêtros)** <br>
public static void executar(string teste)

* Local: 
   * Public: qualquer um tem acesso
   * Private: Privada para o software
   * Internal: tota parte do namespace
   * Protect: publica no programa mas protegida
   
* Tipo
   * Static:
   * Não Static:
   
* Retorno:
   * void: Não retorna nada (não tem o **return**)
   * return: retorna um tipo, int, string, bool...
   
<hr>

### Loops
* Break & Continue:
   * Break: Programa não continua mais.
   * Continue: Programa continua normalmente
   
* While 
```
int i = 0;
while (i < 10)
{
  if (i == 3)
  {
    i++;
    break;
  }
  Console.WriteLine(i);
  i++;
}
```

* Do While
```

```

* For
```
for (int i = 0; i <= 10; i++)
{
  Console.WriteLine(i);
}
```

* ForEach
```
int[] a = { 1, 2, 3, 4, 5 };
foreach (int item in a)
{
  Console.WriteLine(item);
}
```

<hr>

### Array:
* `int[] a = new tipo[];`

* Colection:
```
List<int> a = new List<int>();
   a.Add(1);
   a.Add(2);
```
