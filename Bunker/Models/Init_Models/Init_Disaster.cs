﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Models.Init_Models
{
    class Init_Disaster
    {
        Specifications specifications;
        public Init_Disaster(Specifications _specifications)
        {
            specifications = _specifications;

            Fill_Disaster();
        }

        private void Fill_Disaster()
        {
            specifications.Disaster.Add("Глобальный потоп.\r\nИз-за деятельности человека все полярные снега растаяли покрыв всю Землю водой.\r\nКлимат серьезно нарушился тропики теперь повсюду. Появились новые виды растений и насекомые крупных размеров.\r\nПосле выхода из бункера многие выжившие переквалифицировались в менял/торговцев и бандитов,\r\nкоторые бороздят водные просторы и совершают разбои организованными группами.");
            specifications.Disaster.Add("Супервулкан.\r\nВзрыв Йеллоустонского супервулкана пошатнул Землю, выброшенный в атмосферу пепел закрыл Солнце на несколько месяцев.\r\nНа планете началась ядерная зима. Средняя температура опустилась на 11 градусов, погибли пять из каждых шести населявших Землю существ.\r\nКлимат существенно изменился. На планете теперь царит глобальная засуха.");
            specifications.Disaster.Add("Люди придумали машину времени и теперь население Земли живет в мезозойской эре (нет ничего кроме бункеров)");
            specifications.Disaster.Add("Биотерроризм.\r\nСоздавая более заразный и смертоносный штамм вируса в стенах исследовательской лабораторий один из работников случайно им заразился,\r\nв результате чего вирус вышел из-под контроля и очень быстро распространился по всей планете. Большой процент всех живых существ погиб.\r\nУ остальных существ и растений развились мутации");
            specifications.Disaster.Add("Зомби-апокалипсис.\r\nНеизвестный возбудитель стал причиной превращения людей в кровожадных зомби.\r\nКоллапс системы. Больницы более не функционируют. Тотальная паника. Армия начинает стрелять на поражение при попытке покинуть карантинную зону. Власть уже не может контролировать ситуацию. Начинается тотальное мародерство и анархия. После выхода из бункера малый процент зомби останется в живых");
            specifications.Disaster.Add("Суперкомпьютер.\r\nИскусственный интеллект который задумывался для управления системами обороны вышел из строя и посчитал человечество большой опасностью.\r\nЭто привело к тому, что искусственный интеллект отключил инструкцию 'не убивать человека' и взял под контроль процедуры управления военными роботами,\r\nкоторые начали истреблять человечество. Суперкомпьютер захватил власть над планетой, выжившим людям пришлось прятаться в старых бункерах");
            specifications.Disaster.Add("Ядерная война.\r\nНесколько противоборствующих сторон одновременно запустили друг на друга залп ядерных боеголовок.\r\nПосле взрывов погибло большое количество людей и разразились огромные пожары. Всю планету окутала ядерная пыль закрывшая солнечный свет и приведшая к долгой ядерной зиме.\r\nНаблюдаются проблемы с почвой водой и растительностью на поверхности нужна химическая обработка");
            specifications.Disaster.Add("Химическая война.\r\nВ результате применения химического и бактериологического оружия был нарушен микробиологический состав почв\r\nзначительно изменился экологический баланс растения почва и вода были отравлены. На Земле остался малый процент населяющих её живых существ");
            specifications.Disaster.Add("Проект «Стрела».\r\nВоенные работавшие над проектом нечаянно открыли вход в иное измерение.\r\nГустой неестественный белый туман медленно начал заполонять огромные участки поверхности. Видимость практически нулевая.\r\nПо миру стали бродить неведомые чудовища которые могут уничтожить все человечество. Разрушения глобальные");
            specifications.Disaster.Add("Инопланетная раса решила захватить Землю.\r\nМежпланетные аппараты падают на поверхность планеты один за другим.\r\nОружие военных оказывается бессильным против них и постепенно пришельцы истребляют большую часть населения.\r\nПосле выхода из бункера подавляющее большинство инопланетян погибло из-за неприспособленности к микроорганизмами населяющими Землю");
            specifications.Disaster.Add("Метеорит.\r\nНа планету падает космический объект огромных размеров создавая мощную ударную волну которая сносит все на своем пути На месте падения образовывается масштабный кратер.\r\nПовсюду проходят сильные землетрясения и цунами. Пожары охватывают всю Землю а из-за количество пыли которое поднялось в атмосферу на планете настает долгая 'ядерная зима'");
            specifications.Disaster.Add("Экологическая катастрофа и глобальный голод.\r\nИнтенсивное ведение сельского хозяйства и деградация почв вкупе с засухой привели к пыльным бурям,\r\nкоторые массово уничтожают посевы и приводят к неурожаю и значительному уменьшению запасов пищи.\r\nКонцентрация кислорода в атмосфере падает и климат значительно ухудшается");
            specifications.Disaster.Add("Симианский грипп.\r\nСозданный учеными штамм 'лекарства' от болезни Альцгеймера в итоге стал смертельным для людей что привело к пандемии симианского гриппа\r\nи восходу эволюционировавших обезьян. У всех оставшихся людей есть иммунитет к вирусу но он способен мутировать.\r\nБольший процент обезьян настроен враждебно по отношению к людям");
        }
    }
}
