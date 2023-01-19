using Exercicio_3.Models;
using Exercicio_3.Interfaces;
using Exercicio_3.Models.ClassesAnimais;

Jacare jacare1 = new Jacare(new DateTime(10 / 08 / 2008), 'm');
jacare1.Alimentar();
jacare1.Nadar();

Leão leao1 = new Leão(new DateTime(11 / 09 / 2010), 'f', "laranja");
leao1.Amamentar();
leao1.Comunicar();
leao1.Movimentar();

