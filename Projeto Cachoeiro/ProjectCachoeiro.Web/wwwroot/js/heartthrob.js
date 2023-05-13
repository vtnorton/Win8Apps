function generateMenu() {
    var ids = $('*[id^="main_"]').map(function () {
        return this.id;
    }).get();
    var menu = "<ul>";
    for (var i = 0; i < ids.length; i++) {
        var title = $("#" + ids[i] + " h1").first().text();
        menu += "<li><a onclick='func(" + i + ")' id='nav_" + i + "' data-scroll ";
        if (i === 0) {menu += "class='' ";}
        menu += "href='#" + ids[i] + "'>" + title + "</a>";
        if ($("#" + ids[i]).find("h2")) {
            menu += "<ul style='display:none'>"
            var ids_sub = $('#'+ids[i]+' > *[id^="sub_"]').map(function () { return this.id; }).get();
            for (var j = 0; j < ids_sub.length; j++) {
                var title_sub = $("#" + ids_sub[j] + " h2").first().text();
                menu += "<li><a data-scroll href='#" + ids_sub[j] + "'>" + title_sub + "</a></li>";
            }
            menu += "</ul></li>";
        }else{
            menu += "</li>";
        }
    }
    menu += "</ul>";
    $("#autoMenu").html(menu);
};
function func(x) {
    var as = $('*[id^="nav_"]').map(function () {
        return this.id;
    }).get();
    for (var i = 0; i < as.length; i++) {
        $("#nav_" + i).removeClass("active");
        $("#nav_" + i + " + ul").hide();
    }
    $("#nav_" + x + " + ul").toggle();
    $("#nav_" + x).addClass("active");
}

//There is a jquery appear plugin that I believe does exactly what you are asking.
//http://plugins.jquery.com/project/appear
//$('#theTarget').appear(function() {
//    $(this).text('Hello world');
//});