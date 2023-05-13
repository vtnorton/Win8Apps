var selectedContactUid;

$(document).ready(function () {
    // Attach contact search handler
    $('.search-textbox').on('keyup', function (e) {
        var text = $(e.target).val().toLowerCase();
        var listView = $("#mainWidget").data("kendoListView");

        var dataInView = listView.dataSource.view();
        dataInView.forEach(function (item) {
            var row = $('div[id="' + item.uid + '"]');

            if (item.Name.toLowerCase().indexOf(text) > -1) {
                row.show();
            } else {
                row.hide();
            }
        });
    });
});

// Exporting the ListView of contacts using kendo.drawing
function exportPeople() {
    kendo.drawing.drawDOM($(".inner-section .k-listview"))
        .then(function (group) {
            return kendo.drawing.exportPDF(group, {
                paperSize: "auto",
                margin: { left: "1cm", top: "1cm", right: "1cm", bottom: "1cm" }
            });
        })
        .done(function (data) {
            kendo.saveAs({
                dataURI: data,
                fileName: "Clientes.pdf"
            });
        });
}

// Switch layout between List/Cards view
function changeToListDetails(e) {
    var contactsElement = $('.inner-section');
    contactsElement.removeClass("card-view");
    contactsElement.addClass("list-view");

    updateSelectedViewButton(e);
}

function changeToContactsCards(e) {
    var contactsElement = $('.inner-section');
    contactsElement.removeClass("list-view");
    contactsElement.addClass("card-view");

    updateSelectedViewButton(e);
}

function updateSelectedViewButton(element) {
    var selectedClass = "selected";

    $(".toolbar ." + selectedClass).removeClass(selectedClass);
    $(element).addClass(selectedClass);
}

// ListView event handlers
function onListViewDataBound(e) {
    var listView = e.sender;
    restoreSlection(listView);

    var selectedItem = listView.select();

    if (selectedItem.length === 0) {
        listView.select(listView.element.children().first());
    }
}

function onListViewSelectionChange(e) {
    var selecteditem = e.sender.select();
    var dataItem = e.sender.dataItem(selecteditem);

    if (!dataItem) {
        return;
    }

    var template = kendo.template($('#single-contact-template').html());
    var result = template(dataItem);
    $(".single-contact-details").html(result);
    attachButtonHandlers();
}

function onListViewChangeCancel(e) {
    var cancelEditContactUid = e.model.Id;

    setTimeout(function () {
        var currectContactElement = $('.contact-view[id="' + cancelEditContactUid + '"]');
        e.sender.select(currectContactElement);
    }, 0);
}

function onListViewChangeSave(e) {
    var image = $('img.image-preview');
    var Id = e.model.Id;
    var imgData = getBase64Image(image[0]);
    sessionStorage.setItem(Id, imgData);

    selectedContactUid = e.model.Id;
}

// Restore previously selected item after ListView DataBound
function restoreSlection(listView) {
    if (selectedContactUid) {
        var currectContactElement = $('.contact-view[id="' + selectedContactUid + '"]');
        selectedContactUid = null;
        listView.select(currectContactElement);
    }
}

// Attach handlers for each contact buttons
function attachButtonHandlers() {
    $('.k-single-delete-button').on('click', singleDeleteClick);
}

function singleDeleteClick(e) {
    var uid = getItemUid(e);
    var listView = $("#mainWidget").data("kendoListView");
    if (listView.element.find('[id="' + uid + '"]').length != 0) {
        listView.remove(listView.element.find('[id="' + uid + '"]'));
    }
}

function getItemUid(e) {
    var target = $(e.target);
    var singleItem = target.parents('.contact-view');

    return singleItem.attr('id');
}

// Generate an ID for newly created contact
function getId() {
    var text = "";
    var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    for (var i = 0; i < 5; i++) {
        text += possible.charAt(Math.floor(Math.random() * possible.length));
    }

    return text;
}

// Create preview of the newly selected image
function onImageSelect(e) {
    var fileInfo = e.files[0];

    if (fileInfo.validationErrors && fileInfo.validationErrors.length > 0) {
        return;
    }

    setTimeout(function () {
        addPreview(fileInfo);
    });
}

function addPreview(file) {
    var raw = file.rawFile;
    var reader = new FileReader();

    if (raw) {
        reader.onloadend = function () {
            var image = $('<img class="image-preview">').attr('src', this.result);
            $('.upload-image-wrapper').html(image);
        };

        reader.readAsDataURL(raw);
    }
}

// Retrieve Base 64 image to be stored in a session variable
// This implementation subsititutes the save of the uploaded image to database / server
// which would be in place in a real-life application
function getBase64Image(img) {
    var canvas = document.createElement("canvas");
    canvas.height = img.naturalHeight;
    canvas.width = img.naturalWidth;

    var ctx = canvas.getContext("2d");
    ctx.drawImage(img, 0, 0);
    var dataURL = canvas.toDataURL("image/png");

    return dataURL.replace(/^data:image\/(png|jpg)\;base64,/, "");
}