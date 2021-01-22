var app = (function () {

    function getJson(url, callback, errorMessage, objectParameter = null) {
        if (objectParameter != null) {
            $.getJSON(url, objectParameter, data => callback(data)).fail((jqXHR, textStatus, errorThrown) => {
                app.consoleLog('Request fail', textStatus, errorThrown);
                app.dialog.alert(errorMessage);
            });
        } else {
            $.getJSON(url).done(data => callback(data)).fail((jqXHR, textStatus, errorThrown) => {
                app.consoleLog('Request fail', textStatus, errorThrown);
                app.dialog.alert(errorMessage);
            });
        }
    }

    function ajax(url, data, callback, errorMessage) {
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'text',
            type: 'POST',
            url: url,
            data: data
        }).done((data) => callback(JSON.parse(data))).fail((jqXHR, textStatus, errorThrown) => {
            app.consoleLog('Request fail', textStatus, errorThrown);
            app.dialog.alert(errorMessage);
        });
    }

    function consoleLog(title, ...args) {
        console.log(title + ': ', args.join(', '));
    }

    function bindDataTable(tableId, properties, data) {
        var tableColumns = [];

        properties.forEach(property => tableColumns.push({ 'mDataProp': property }));

        $(tableId).DataTable({
            'aaData': data,
            'aoColumns': tableColumns,
            'sScrollX': '100%',
            'sScrollXInner': '100%',
            'bInfo': false,
            destroy: true,
            paging: false,
            searching: false,
            ordering: false
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

    var dialog = {
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

    var twbsPagination = {
        setup: function (paginationId, totalPages, pageIndex, callback) {
            $(paginationId).html('');
            $(paginationId).html('<ul id="pagination" class="pagination">');
            $(paginationId + ' > #pagination').twbsPagination({
                initiateStartPageClick: false,
                totalPages: totalPages,
                startPage: pageIndex + 1,
                onPageClick: function (event, page) {
                    callback(paginationId, page - 1);
                }
            });
        },
        refresh: function (paginationId, totalPages) {
            $(paginationId + '> #pagination').twbsPagination({ totalPages: totalPages });
        }
    };

    return {
        getJson: getJson,
        ajax: ajax,
        consoleLog: consoleLog,
        bindDataTable: bindDataTable,
        bindSelect2: bindSelect2,
        dialog: dialog,
        twbsPagination: twbsPagination
    }
})();