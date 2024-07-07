# Marabaka (Xamarin.Forms)
Данное приложение было моим тестовым заданием в 2020 году и представляет собой социальную сеть для подростков. 
This application was my test assignment in 2020 and represents a social network for teenagers.

Главная - странца с табами (TabbedPage). Первая вкладка - страница с верхними табами. На первой вкладке список из карточек (1 скриншот). С каждой карточки можно перейти на список подписчиков/подписок (2 скриншот) и в кастомизацию профиля (3 скриншот), где расположен BottomSheet, которого на то время в Xamarin.Forms не было.
The main page is a TabbedPage. The first tab is a page with upper tabs. On the first tab, there is a list of cards (1 screenshot). From each card, you can transition to a list of subscribers/followers (2 screenshot) and profile customization (3 screenshot), where a BottomSheet was located which did not exist back then.

За базовую архитектуру взят [OrderKing](https://github.com/Binwell/Order-King-Mobile-Core) компании Binwell. Имеется слой DAL для имитации REST-запросов и UI StateContainer.
The basic architecture is based on OrderKing by Binwell. There is a DAL layer for simulating REST requests and UI StateContainer.

Используемые пакеты:
Used packages:
1) [Acr.UserDialogs](https://github.com/aritchie/userdialogs) Стандартные пользовательские диалоги (Standard user dialogs)
2) [Rg.Plugins.Popup](https://github.com/rotorgames/Rg.Plugins.Popup) Попап-страницы (Popup pages)
3) [Refit](https://github.com/reactiveui/refit) Rest-запросы (REST requests)
4) [Xamarin.Forms.PancakeView](https://github.com/sthewissen/Xamarin.Forms.PancakeView) Красивые карточки с градиентом (Beautiful cards with gradient)

![Screenshot_1720365874](https://github.com/OlegTiotenshi/Marabaka/assets/63308514/b319e830-5035-4704-8932-f4c6c32fec38)
![Screenshot_1720366027](https://github.com/OlegTiotenshi/Marabaka/assets/63308514/424b78c2-75ce-43e2-a11e-129b96b6511b)
![Screenshot_1720366078](https://github.com/OlegTiotenshi/Marabaka/assets/63308514/6e31be1b-2058-4b4e-a2e4-994214835e34)
