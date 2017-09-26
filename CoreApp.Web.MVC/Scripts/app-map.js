var Maps = (function () {
    var instance;
    var positionDefault = { lat: -23.554592, lng: -46.631332 };

    return {
        get: function () {
            if (!instance) {
                instance = new google.maps.Map(document.getElementById('map'), {
                    center: positionDefault,
                    zoom: 10
                });
                if (navigator.geolocation) {
                    navigator.geolocation.getCurrentPosition(function (position) {
                        instance.setCenter({ lat: position.coords.latitude, lng: position.coords.longitude });
                    }, function () {
                        alert('The Geolocation service failed');
                    });
                }
            }
            return instance;
        },
        getAll: function () {
            $.ajax({
                url: "/Restaurant/GetAll",
                type: "GET",
                dataType: "json",
                success: function (data) {
                    data.forEach(function (restaurant) {
                        var marker = new google.maps.Marker({
                            position: { lat: restaurant.Lat, lng: restaurant.Lon },
                            icon: {
                                url: 'Img/restaurant.png'
                            },
                            map: instance,
                            title: restaurant.Name
                        });
                    });
                }
            });
        }
    };
})();


$(function () {
    $("#btRefresh").click(function () {
        Maps.getAll();
    });
});