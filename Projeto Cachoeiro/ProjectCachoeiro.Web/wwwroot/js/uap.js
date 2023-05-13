$(document).ready(function () {
    var boxheight = $(".box").height() / 2;
    $(".box").css("margin-top", "calc(25% - " + boxheight + "px)");
});
//200px
//calc(50% - 200/2)