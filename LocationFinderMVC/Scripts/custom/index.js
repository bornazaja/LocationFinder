$(window).on('load', function () {
    app.dialog.loading([fetchCategories()]);
});

$('#btnApply').click(function () {
    $('#filterModal').modal('hide');
    app.dialog.loading([findCurrentLocation()]);
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
        fetchItemsPerPageList();
    }, 'Error occur while retriving radiuses.');
}

function fetchItemsPerPageList() {
    app.getJson('/Home/GetItemsPerPageList', (data) => {
        app.bindSelect2("#ddlItemsPerPage", data);
        findCurrentLocation();
    });
}

function findCurrentLocation() {
    navigator.geolocation.getCurrentPosition(fetchNearbyPlaces);
}

function fetchNearbyPlaces(position) {
    var parameters = {
        Latitude: position.coords.latitude,
        Longitude: position.coords.longitude,
        RadiusInMeters: $('#ddlRadiuses').val(),
        CategoryID: $('#ddlCategories').val(),
        PageIndex: 0,
        PageSize: $('#ddlItemsPerPage').val()
    };


    app.getJson('/Home/GetNearbyPlacesAsync', parameters, (data) => {
        app.bindDataTable('#tblNearbyPlaces', ['Address', 'Place', 'Category'], data.Subset);
        app.twbsPagination.setup('#nearbyPlacesPagination', data.TotalPages, data.PageIndex, (paginationId, pageIndex) => {
            parameters.PageIndex = pageIndex;
            app.dialog.loading([
                app.getJson('/Home/GetNearbyPlacesAsync', parameters, (data) => {
                    app.bindDataTable('#tblNearbyPlaces', ['Address', 'Place', 'Category'], data.Subset);
                    app.twbsPagination.refresh(paginationId, data.TotalPages);
                }, 'Error occur while retriving nearby places.')
            ]);
        });
    }, 'Error occur while retriving nearby places.');
}