$(window).on('load', function () {
    app.dialog.loading([fetchCategories()]);
});

$('#btnApply').click(function () {
    $('#filtersModal').modal('hide');
    app.dialog.loading([findCurrentLocation()]);
});

$('#btnReset').click(function () {
    $('#txtTerm').val('');
    app.setSelectFirstValue('#ddlRadiuses');
    app.setSelectFirstValue('#ddlCategories');
    app.setSelectFirstValue('#ddlItemsPerPage');
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
    }, 'Error occur while retriving items per page list.');
}

function findCurrentLocation() {
    navigator.geolocation.getCurrentPosition(fetchNearbyPlaces);
}

function fetchNearbyPlaces(position) {
    var placeCriteriaDto = {
        Latitude: position.coords.latitude,
        Longitude: position.coords.longitude,
        Term: $('#txtTerm').val(),
        RadiusInMeters: $('#ddlRadiuses').val(),
        CategoryID: $('#ddlCategories').val(),
        PageCriteriaDto: {
            PageIndex: 0,
            PageSize: $('#ddlItemsPerPage').val()
        }
    };

    prepareNearbyPlaces(placeCriteriaDto, (data) => {
        app.twbsPagination.setup('#nearbyPlacesPagination', data.TotalPages, (paginationId, pageIndex) => {
            placeCriteriaDto.PageCriteriaDto.PageIndex = pageIndex;
            app.dialog.loading([prepareNearbyPlaces(placeCriteriaDto, (data) => app.twbsPagination.refresh(paginationId, data.TotalPages))]);
        });
    });
}

function prepareNearbyPlaces(data, callback) {
    app.ajax('/Home/GetNearbyPlacesAsync', JSON.stringify({ placeCriteriaDto: data }), (data) => {
        app.bindDataTable('#tblNearbyPlaces', ['Address', 'Place', 'Category'], data.Subset);
        callback(data);
    }, 'Error occur while retriving nearby places.');
}