# TortugaC_VoytsekhovichNikita

## Введение
Данное приложение разрабатывалось для кафе-ресторана “TortugaC”, в главный функционал должно входить: Выбор свободного столика в ресторане, просмотр меню, заказ блюд. При разработке приложения было принято решение не использовать API(Application Programming Interface), и ограничится одной базой данных для работы данного приложения. Помимо этого приложение было написано как Desktop application(Десктоп приложение), для работы непосредственно на терминале с установленной ОС Windows. 
## Usecase диаграмма
Для данного приложения была разработана Usecase диаграмма, которая в кратце показывает весь возможный функционал приложения с точки зрения пользователя-клиента.
![image](https://user-images.githubusercontent.com/53102064/216609619-d2c41715-7ac9-43ad-ad63-fbb70656d775.png)

## Дизайн приложения
Также для приложения был сделан дизайн-набросок для того, чтобы показать примерный визуальный вид готового бизнес-приложения.
![image](https://user-images.githubusercontent.com/53102064/216609640-bd1c5151-f04e-49f2-ad4a-cb9b7667f74b.png)
![image](https://user-images.githubusercontent.com/53102064/216609672-0459ca59-b287-4aec-8a66-f5a41d6c50c2.png)
![image](https://user-images.githubusercontent.com/53102064/216609705-6fe39f12-a8ac-49c7-a1f3-b1f831101ced.png)
![image](https://user-images.githubusercontent.com/53102064/216609722-5eb95ab5-e84c-44f7-bc82-391b5390d965.png)
![image](https://user-images.githubusercontent.com/53102064/216609748-daaa6e10-bb0a-4f35-8f64-065ca0ca79ba.png)





## База данных приложения
Была написана база данных, которая будет обеспечивать работу приложения. В ней реализован полный функционал необходимый для бесперебойной работы приложения. Список сотрудников, полный список блюд, категорий к которым они относятся, список всех столиков в заведении, и т.д
Это все позволяет реализовать приложение с всем необходимым функционалом.
![image](https://user-images.githubusercontent.com/53102064/216609805-5623b69a-379f-4ce6-b61f-ab2bebbf8ca7.png)

### Таблица Product
В данной таблице находятся все записи блюд, которые есть в меню, здесь указаны их названия, описания блюд, их цена, вес, ингредиенты, скидка, и актуальность(Доступны ли для продажи)
### Таблица Category
В данной таблице указаны все категории блюд, которые есть в меню, для удобной сортировки блюд в приложении. У каждого блюда есть категория, но не более одной(Для простоты разработки и использования приложения)
### Таблица Employee
В данной таблице указаны все сотрудники, их ФИО и дата рождения, минимально необходимая информация, это необходимо для того, чтобы можно было распределять заказы по разным поварам, по их специальности и т.д
Но данный функционал необходимо реализовать в приложении для сотрудников, в котором будет расширенный функционал для поваров и официантов . В данном случае при заказе указывается официант, который должен будет обслужить заказ на данном столике.

### Таблица Status
Данная таблица нужна только для того, чтобы хранить различные статусы приготовления заказа(В процессе, задерживается, готово и т.д)
### Таблица Order
Это основная таблица для заказа через приложение, после кнопки заказать - заказ из приложения отправляется эту таблицу, в которой будет указано: Номер столика, Общая стоимость заказа, сотрудник, который будет обслуживать данный заказ, статус заказа, описание(Для дополнительной информации), и дата с временем, когда был сделан заказ. Продукты в данной таблице не указываются, это делается в другой таблице ProductOrder
### Таблица ProductOrder
В данной таблице указаны все заказанные блюда, к каким заказам они относятся, количество заказанных порций и статус их приготовления.
## Приложение
###Пользовательская документация

#### Окно выбора столика

Окно выбора столика, здесь отображаются все доступные столики в заведении, в записи отображается их название и описание, благодаря чему гости смогут выбрать столик, который им точно подойдет. После нажатия кнопки выбрать столик запоминается, и при заказе каких либо блюд - они будут относится именно к этому столику, благодаря чему официанты смогут без лишних проблем понять что куда нужно относить. Также после нажатия кнопки выбрать идет переход на следующее окно с Меню.
![image](https://user-images.githubusercontent.com/53102064/216609852-8c2e773e-c5f8-49c3-8b64-a165692f15c4.png)

#### Окно Меню

На этом окне пользователь видит все основное меню заведения, есть возможность сортировать блюда по категориям, просматривать дополнительную информацию о блюдах, смотреть в режиме реального времени сколько стоит то, что пользователь добавил себе в корзину, а также еще возможность поменять столик(Без потери содержимого корзины), а также переход в саму корзину для оплаты заказа. Сами карточки блюд содержат только самую основную информацию а именно: Название блюда, его цена, фото. Дополнительную информацию можно получить нажав на кнопку информации.
![image](https://user-images.githubusercontent.com/53102064/216609891-2170436e-debc-4153-8745-2ce5ad77b30e.png)

#### Окно дополнительной информации о блюде

На этом диалоговом окне выводится вся дополнительная информация, которая не поместилась в основной карточке в меню, а именно: Описание блюда, состав блюда, его вес, наличие скидки. Также при наличии скидки на блюдо сразу считается цена блюда, с учетом скидки, и при добавлении блюда в корзину будет учитываться именно эта цена.
![image](https://user-images.githubusercontent.com/53102064/216609936-a312bed2-b551-4c72-9d5b-39a5875feb8b.png)
![image](https://user-images.githubusercontent.com/53102064/216609963-da32633b-597b-4c88-8ba7-b5b575b2c78c.png)

#### Окно смены столика

При нажатии на кнопку смены столика, по факту открывается тоже самое первоначальное окно с выбором стола и с тем же функционалом, но при этом все добавленные блюда в корзину никуд не денутся и все сохраняется, поэтому по факту сменяется лишь стол, на который как итог заказ будет выдан.
![image](https://user-images.githubusercontent.com/53102064/216610011-894ae4ad-221f-4764-b641-51264eff8f9c.png)

#### Окно корзины

На этом окне пользователь может управлять тем, что добавил в корзину, добавлять больше блюд, удалять их из корзины, есть возможность вернутся к Меню, либо сменить стол. Итоговая цена корзины считается с учетом всех скидок, и возможной скидки белой субботы, если она действительно есть. После нажатия кнопки заказать - заказ отправляется в базу данных, записывается в таблицы, и уже готов для дальнейшей обработки.
![image](https://user-images.githubusercontent.com/53102064/216610046-f1f41820-f67d-43f9-acde-096dd5ef4fa7.png)

### Техническая документация
#### Окно выбора столика

В этом окне вывод данных реализован через ListView, сделано это для удобства обновления информации о столиках, все изменения названий столов, описаний, новые стола и т.д все будет выведено автоматически в удобной форме, без надобности обновлять информацию вручную в приложении. При нажатии на кнопку выбрать происходит переход на следующее окно и также записывается ID стола в глобальную переменную, которая будет необходима, чтобы указать в заказе номер стола, с которого делали заказ.
![image](https://user-images.githubusercontent.com/53102064/216610139-5f7f4696-ab02-43af-911a-85c621a3ce79.png)
![image](https://user-images.githubusercontent.com/53102064/216610102-944e581e-3d37-44a3-a6e0-fea503292aa0.png)

####Окно Меню

Здесь также вывод сделан через ListView, также для удобства обновления данных, без лишнего вмешательства в работу приложения. 

В основном классе мы прописываем ItemSource для ListView категории, и также указываем нулевой индекс(По умолчанию) - отображение всех блюд. Метод totalPrice считает цену продуктов добавленных в корзину. По факту после каждого клика кнопки купить мы берем указанную запись блюда и добавляем ее в глобальный лист типа Product, это и есть наша корзина. после чего мы можем спокойно считать цену всех продуктов этого листа, не забывая о скидках и о скидке белой субботы, на этом окне этот метод нужен для того, чтобы пользователь мог видеть общую стоимость корзины, стоимость обновляется при каждом изменении корзины(Покупки). 

Метод фильтр нужен для того, чтобы пользователь мог сортировать блюда по категориям. При нажатии на элемент ListView категории мы берем ID категории, и просто заполняем ListView блюд теми позициями, у которых есть данный ID Категории. 

Метод для добавления блюда в корзину, мы берем из выбранного элемента ListView запись блюда и добавляем в свой глобальный лист(Корзину), все очень просто.
![image](https://user-images.githubusercontent.com/53102064/216610185-a7b7d097-5dd5-430f-a82a-89bd89bf988a.png)
![image](https://user-images.githubusercontent.com/53102064/216610220-dcf17d38-02ba-46e5-b259-c0576f7a871d.png)
![image](https://user-images.githubusercontent.com/53102064/216610259-756d8ae2-93ad-4509-a95f-4370bfe81903.png)
![image](https://user-images.githubusercontent.com/53102064/216610278-9c31d92c-7c2e-4f72-a852-7b6e7edd5a8d.png)

#### Окно корзины

В этом окне мы также используем все тот же метод totalPrice для подсчета стоимости корзины, он учитывает все возможные скидки включая скидку белой субботы
Метод для обновления ListView при изменении в нем данных, это может быть уменьшение количества блюд увеличение, удаление блюда и т.д

Также методы для увеличения, уменьшения и удаления блюд в корзине

Метод для добавления заказа в базу данных, здесь предусмотрены возможные проблемы с подключением к базе данных, поэтому здесь используется try catch для обработки возможных ошибок в работе приложения. Все что происходит в этом методе это всего лишь запись уже имеющихся данных в базу данных через цикл, который прогоняет все записи в глобальном листе, и каждую запись добавляет в базу данных, благодаря чему каждое заказанное блюдо будет приготовлено и обработано в базе данных, после заказа корзина очищается и пользователя переводит на основное окно выбора столика
![image](https://user-images.githubusercontent.com/53102064/216610313-097772fd-698e-4949-8a29-dad649dcddf5.png)
![image](https://user-images.githubusercontent.com/53102064/216610340-712a8a5d-db17-4604-811d-eb8cbe0543f1.png)
![image](https://user-images.githubusercontent.com/53102064/216610371-5eaa821e-d9dd-4cbd-ac59-fc06093b99d0.png)
![image](https://user-images.githubusercontent.com/53102064/216610405-a4e42d7f-bbb4-409a-b0eb-fed526c17915.png)
![image](https://user-images.githubusercontent.com/53102064/216610435-a60b7226-268b-4f83-93cc-02198762067e.png)

