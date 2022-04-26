using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Models.Init_Models
{
    class Init_Health
    {
        private Specifications specifications;
        public Init_Health(Specifications _specifications)
        {
            specifications = _specifications;
            Fill_Health();
        }

        private void Fill_Health()
        {
            specifications.Health.Add("Полностью здоров(а)");
            specifications.Health.Add("Абфракция");
            specifications.Health.Add("Аденоиды");
            specifications.Health.Add("Аллергический ринит(Хронический)");
            specifications.Health.Add("Анальный миаз");
            specifications.Health.Add("Аргентинская геморрагическая лихорадка");
            specifications.Health.Add("Болезнь Альцгеймера(Предеменция)");
            specifications.Health.Add("Болезнь Альцгеймера(Ранняя деменция)");
            specifications.Health.Add("Болезнь Альцгеймера(Умеренная деменция)");
            specifications.Health.Add("Болезнь Альцгеймера(Тяжёлая деменция)");
            specifications.Health.Add("Бородавчатая эпидермодисплазия(Вся левая рука)");
            specifications.Health.Add("Вирусный гепатит(Врождённый вирусный гепатит)");
            specifications.Health.Add("Вирусный гепатит(Острый вирусный гепатит)");
            specifications.Health.Add("Вирусный гепатит(Первично-хронический вирусный гепатит)");
            specifications.Health.Add("Вирусный гепатит(Вторично-хронический вирусный гепатит)");
            specifications.Health.Add("Височная эпилепсия");
            specifications.Health.Add("Волосяной лишай");
            specifications.Health.Add("Вульводиния - женщина, закрут яичка(только что образованный) - мужчина ");
            specifications.Health.Add("Герпес (1-2 типа)");
            specifications.Health.Add("Ветрянка (Первые признаки)");
            specifications.Health.Add("Грипп (Тяжелое течение, осложнений нет)");
            specifications.Health.Add("Грыжа спины (1 стадия)");
            specifications.Health.Add("Грыжа спины (2 стадия)");
            specifications.Health.Add("Грыжа спины (3 стадия)");
            specifications.Health.Add("Грыжа спины (4 стадия)");
            specifications.Health.Add("Злокачественный нейролептический синдром (Пик болезни)");
            specifications.Health.Add("Контактный дерматит (на пыль)");
            specifications.Health.Add("Конъюнктивит (Блефароконъюнктивит)");
            specifications.Health.Add("Конъюнктивит (Кератоконъюнктивит)");
            specifications.Health.Add("Конъюнктивит (Эписклерит)");
            specifications.Health.Add("Коровья оспа (Без симптомов)");
            specifications.Health.Add("Красный плоский лишай");
            specifications.Health.Add("Лимфоцитарная интерстициальная пневмония");
            specifications.Health.Add("Лучевая болезнь");
            specifications.Health.Add("Натуральная оспа");
            specifications.Health.Add("Острая лучевая болезнь");
            specifications.Health.Add("Паразитарные краниопаги (Близнец живой, занимает слот в бункере по еде и воде, зовут Альфред, по развитию 3,5 собачих лет." +
                "У Альфреда запущенный синдром Туретта + Конъюнктивит (Эписклерит) и Герпес (3 типа)) сочувствую :(");
            specifications.Health.Add("Потница");
            specifications.Health.Add("Разговоры во сне");
            specifications.Health.Add("Рак губы (1 стадия)((курил не взатяг))");
            specifications.Health.Add("Рак губы (2 стадия)((курил не взатяг))");
            specifications.Health.Add("Рак губы (3 стадия)((курил не взатяг))");
            specifications.Health.Add("Рак губы (4 стадия)((курил не взатяг))");
            specifications.Health.Add("Рак поджелудочной железы (1 стадия)");
            specifications.Health.Add("Рак поджелудочной железы (2 стадия)");
            specifications.Health.Add("Рак поджелудочной железы (3 стадия)");
            specifications.Health.Add("Рак поджелудочной железы (4 стадия)");
            specifications.Health.Add("Сахарный диабет (1 - типа, легкое течение)");
            specifications.Health.Add("Сахарный диабет (1 - типа, среднея степень)");
            specifications.Health.Add("Сахарный диабет (1 - типа, тяжелое течение)");
            specifications.Health.Add("Сахарный диабет (2 - типа, легкое течение)");
            specifications.Health.Add("Сахарный диабет (2 - типа, среднея степень)");
            specifications.Health.Add("Сахарный диабет (2 - типа, тяжелое течение)");
            specifications.Health.Add("Свиной грипп (легкое течение)");
            specifications.Health.Add("Свиной грипп (среднея степень)");
            specifications.Health.Add("Свиной грипп (тяжелое течение)");
            specifications.Health.Add("Септический артрит (Начало болезни)");
            specifications.Health.Add("Заячья губа");
            specifications.Health.Add("Волчья пасть");
            specifications.Health.Add("Укорочение уздечки языка");
            specifications.Health.Add("Гинекомастия");
            specifications.Health.Add("Аносмия");
            specifications.Health.Add("Гипогонадизм - мужчина, Миома матки - женщина ");
            specifications.Health.Add("Маршевая стопа");
            specifications.Health.Add("Мицетома");
            specifications.Health.Add("Омфалит");
            specifications.Health.Add("Транспозиция внутренних органов");
            specifications.Health.Add("Отит (Хронический)");
            specifications.Health.Add("Мышечная гипотония");
            specifications.Health.Add("Синдром кошачьего крика");
            specifications.Health.Add("Синдром Ларона (Рост - 63 см, Вес - 15 кг)");
            specifications.Health.Add("Синдром Мёбиуса");
            specifications.Health.Add("Синдром Сотоса (Рост - 210 см, Вес - 130кг)");
            specifications.Health.Add("Синдром Тричера Коллинза");
            specifications.Health.Add("Токсикомания");
            specifications.Health.Add("Торсионная дистония");
            specifications.Health.Add("Хейлит");
            specifications.Health.Add("Экзостоз (легкое течение)");
            specifications.Health.Add("Экзостоз (среднея степень)");
            specifications.Health.Add("Экзостоз (тяжелое течение)");
            specifications.Health.Add("Эктродактилия (Отсутствуют все пальцы на руке и ноге)");
            specifications.Health.Add("Эктродактилия(Остался по 1 пальцу на ногах)");
            specifications.Health.Add("Аллергия (Цитрусы) (легкая степень)");
            specifications.Health.Add("Аллергия (Цитрусы) (средняя степень)");
            specifications.Health.Add("Аллергия (Цитрусы) (тяжелая степень)");
            specifications.Health.Add("Аллергия (Пыль) (легкая степень)");
            specifications.Health.Add("Аллергия (Пыль) (средняя степень)");
            specifications.Health.Add("Аллергия (Пыль) (тяжелая степень)");
            specifications.Health.Add("Аллергия (Вода) (тяжелая степень)");
            specifications.Health.Add("Аллергия (Перхоть животных) (легкая степень)");
            specifications.Health.Add("Аллергия (Перхоть животных) (средняя степень)");
            specifications.Health.Add("Аллергия (Перхоть животных) (тяжелая степень)");
            specifications.Health.Add("Косоглазие (легкая степень)");
            specifications.Health.Add("Косоглазие (средняя степень)");
            specifications.Health.Add("Косоглазие (тяжелая степень)");
            specifications.Health.Add("Нет ноги");
            specifications.Health.Add("Нет ног");
            specifications.Health.Add("Нет руки");
            specifications.Health.Add("Нет рук");
            specifications.Health.Add("Нет глаза");
            specifications.Health.Add("Слепота (легкая степень)");
            specifications.Health.Add("Слепота (средняя степень)");
            specifications.Health.Add("Слепота (тяжелая степень)");
            specifications.Health.Add("Нет пальцев на руке");
            specifications.Health.Add("Нет пальцев на ноге");
            specifications.Health.Add("Нет пальце на руках");
            specifications.Health.Add("Нет пальцев на ногах");
            specifications.Health.Add("Облысение");
            specifications.Health.Add("Астма (легкая степень)");
            specifications.Health.Add("Астма (средняя степень)");
            specifications.Health.Add("Астма (тяжелая степень)");
            specifications.Health.Add("Туберкулез (без симптомов)");
            specifications.Health.Add("Туберкулез (легкая степень)");
            specifications.Health.Add("Туберкулез (средняя степень)");
            specifications.Health.Add("Туберкулез (тяжелая степень)");
            specifications.Health.Add("Короновирус (без симптомов)");
            specifications.Health.Add("Короновирус (легкая степень)");
            specifications.Health.Add("Короновирус (средняя степень)");
            specifications.Health.Add("Короновирус (тяжелая степень)");
            specifications.Health.Add("Бесплодие");
        }
    }
}
