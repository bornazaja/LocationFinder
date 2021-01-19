var app = (function () {

    function getJson(url, objectParameter = null, callback, errorMessage) {
        if (objectParameter != null) {
            $.getJSON(url, objectParameter, data => callback(data)).fail(() => app.dialogHelper.alert(errorMessage));
        } else {
            $.getJSON(url).done(data => callback(data)).fail(() => app.dialogHelper.alert(errorMessage));
        }
    }

    function bindDataTable(tableId, properties, data) {
        var tableColumns = [];

        properties.forEach(property => tableColumns.push({ 'mDataProp': property }));

        $(tableId).DataTable({
            'aaData': data,
            'aoColumns': tableColumns,
            'sScrollX': '100%',
            'sScrollXInner': '100%',
            destroy: true
        });
    }

    function bindSelect2(ddlId, data) {
        data = $.map(data, function (item) {
            return { id: item.Key, text: item.Value };
        });

        $(ddlId).select2({
            data: data
        });

        $(ddlId).val($(ddlId + ' option:eq(0)').val()).trigger('change');
    }

    var dialogHelper = {
        alert: function (message, callback = null) {
            bootbox.alert({
                message: message,
                buttons: {
                    ok: {
                        label: 'OK',
                        className: 'btn-secondary'
                    }
                },
                callback: () => {
                    if (callback != null) {
                        callback();
                    }
                }
            });
        },
        loading: function (promises) {
            var dialog = bootbox.dialog({
                message: '<div class="d-flex align-items-center flex-column"><div class="spinner-border text-secondary mb-3" role="dialog"></div><p>Loading...</p></div>',
                closeButton: false
            });

            Promise.all(promises).then(() => setTimeout(() => dialog.modal('hide'), 700));
        }
    };

    return {
        getJson: getJson,
        bindDataTable: bindDataTable,
        bindSelect2: bindSelect2,
        dialogHelper: dialogHelper
    }
})();