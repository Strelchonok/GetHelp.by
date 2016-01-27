ymaps.ready(function () {
    var myMap = new ymaps.Map('map', {
        center: [53.939084, 27.650566],
        zoom: 16
    }, {
        searchControlProvider: 'yandex#search'
    }),
        myPlacemark = new ymaps.Placemark(myMap.getCenter(), {
            hintContent: 'GetHelp.by +375 29 3-115-915',
            balloonContent: 'Минск, ул. Калиновского, 66а'
        }, {
            // Опции.
            // Необходимо указать данный тип макета.
            iconLayout: 'default#image',
            // Своё изображение иконки метки.
            iconImageHref: '../Content/images/Visuals/myIcon.png',
            // Размеры метки.
            iconImageSize: [29, 42],
            // Смещение левого верхнего угла иконки относительно
            // её "ножки" (точки привязки).
            iconImageOffset: [-3, -42]
        });

    myMap.geoObjects.add(myPlacemark);
});