$(document).ready(function () {
    var altura = $(window).height() - 48;
    $(".nav-pane").css("height", altura + "px");
    NProgress.start();
    NProgress.done();

    $("content").niceScroll({
        cursorcolor: "#52658C",
        cursorwidth: "12px",
        cursorborder: "0px solid #000",
        scrollspeed: 60,
        autohidemode: false,
        background: '#ddd',
        hidecursordelay: 400,
        cursorfixedheight: false,
        cursorminheight: 20,
        enablekeyboard: true,
        horizrailenabled: true,
        bouncescroll: false,
        smoothscroll: true,
        iframeautoresize: true,
        touchbehavior: false,
        zindex: 99,
        cursorborderradius: "0px"
    });

    $(".nav-navigation-list ul li ul").niceScroll({
        cursorcolor: "#52658C",
        cursorwidth: "12px",
        cursorborder: "0px solid #000",
        scrollspeed: 60,
        autohidemode: false,
        background: '#404040',
        hidecursordelay: 400,
        cursorfixedheight: false,
        cursorminheight: 20,
        enablekeyboard: true,
        horizrailenabled: true,
        bouncescroll: false,
        smoothscroll: true,
        iframeautoresize: true,
        touchbehavior: false,
        zindex: 9,
        cursorborderradius: "0px"
    });
});

$("content").mouseover(function () {
    $("content").getNiceScroll().resize();
});

/*
 * O nome disso é gambiarra!
 * Gambiarra a gente aceita,
 * o que a gente não aceita é a derrota!
 */
function openEdit(e) {
    var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
    window.location.href = e.currentTarget.pathname + "/Edit/" + dataItem.id;
}

function openDetails(e) {
    var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
    var url = e.currentTarget.pathname + "/Details/" + dataItem.id;
    window.location.href = url;
}

function error_handler(e) {
    if (e.errors) {
        var message = "Errors:\n";
        $.each(e.errors, function (key, value) {
            if ('errors' in value) {
                $.each(value.errors, function () {
                    message += this + "\n";
                });
            }
        });
        alert(message);
    }
}