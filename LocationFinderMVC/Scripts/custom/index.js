$(window).on('load', function () {
    app.dialogHelper.loading([fetchCategories()]);
});

$('#btnApply').click(function () {
    app.dialogHelper.loading([findCurrentLocation()]);
    $('#filterModal').modal('hide');
});

function fetchCategories() {
    app.getJson('/Home/GetCategoriesAsync', (data) => {
        app.bindSelect2('#ddlCategories', data);
        fetchRadiuses();
    }, 'Error occur while retriving categories.');
}

function fetchRadiuses() {
    app.getJson('/Home/GetRadiuses', (data) => {
        app.bindSelect2('#ddlRadiuses', data);
        findCurrentLocation();
    }, 'Error occur while retriving radiuses.');
}

function findCurrentLocation() {
    navigator.geolocation.getCurrentPosition(fetchNearbyPlaces);
}

function fetchNearbyPlaces(position) {
    var filter = {
        Latitude: position.coords.latitude,
        Longitude: position.coords.longitude,
        RadiusInMeters: $('#ddlRadiuses').val(),
        CategoryID: $('#ddlCategories').val()
    };

    app.getJson('/Home/GetNearbyPlacesAsync', filter, (data) => {
        app.bindDataTable('#tblNearbyPlaces', ['Address', 'Place', 'Category'], data);
    }, 'Error occur while retriving nearby places.');
}