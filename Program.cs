double raio, area, diametro, perimetro;

Console.Write("Digite o valor do raio do circulo: ");

raio = Convert.ToDouble(Console.ReadLine());

area = Math.PI*Math.Pow(raio,2);
diametro = 2*raio;
perimetro = 2*Math.PI*raio;

Console.WriteLine($"A área é igual a: {area:N2}\nO diamentro é igual a: {diametro:N2} \nO perimetro é igual a: {perimetro:N2}");