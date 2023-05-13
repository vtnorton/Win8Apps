$(document).ready(function () {
    $.fn.clickToggle = function (func1, func2) {
        var funcs = [func1, func2];
        this.data('toggleclicked', 0);
        this.click(function () {
            var data = $(this).data();
            var tc = data.toggleclicked;
            $.proxy(funcs[tc], this)();
            data.toggleclicked = (tc + 1) % 2;
        });
        return this;
    };
    if ($(window).width() <= 895) {
        $("nav").css("display", "none");
    }
    $(".hamburger").click(function () {
        $("nav").slideToggle("fast");
        if ($(window).width() > 400) {
            $(".logo-written").toggle();
        }
    });
    $(".minimenu-acess").click(function () {
        $(".minimenu-panel-acess").slideToggle("fast");
        $(".minimenu-panel-denunciar").hide();
        $(".minimenu-panel-acess-help").hide("fast");
    });

    $(".minimenu-denunciar").click(function () {
        $(".minimenu-panel-denunciar").slideToggle("fast");
        $(".minimenu-panel-acess").hide();
        $(".minimenu-panel-acess-help").hide();
    });
    $(".minimenu-acess-fonte").click(function () {
        $(".minimenu-acess-fonte-lista").slideToggle("fast");
    });
    var pFontSize = 14, pH1 = 30, pH2 = 27, pH3 = 25, pH4 = 20, pH5 = 16, pLineHeight = 19;
    var pFontFamily = "'Segoe UI', Arial, Helvetica, Tahoma, Geneva, Verdana, sans-serif", pTextAlign = "left";
    $(".minimenu-acess-fonte-maior").click(function () {
        if (pFontSize < 42) {
            if (pFontSize <= 19) {
                $("p").css("font-size", pFontSize++ + "px");
                $("article h1").css("font-size", pH1++ + "px");
            }
            if ((pFontSize < 42) || (pFontSize > 20)) {
                $("p").css({ "font-size": pFontSize++ + "px", "line-height": pLineHeight++ + "px" });
                $("article h1").css("font-size", pH1++ + "px");
            }
        }
    });
    $(".minimenu-acess-fonte-menor").click(function () {
        if (pFontSize >= 10) {
            $("p").css("font-size", pFontSize-- + "px");
            $("article h1").css("font-size", pH1-- + "px");
        }
        if ((pFontSize < 42) || (pFontSize > 20)) {
            $("p").css("line-height", pLineHeight + "px");
        }
    });
    $("#arial").click(function () {
        $("article").css("font-family", "Arial");
        $("p").css("font-family", "Arial");
    });
    $("#georgia").click(function () {
        $("article").css("font-family", "Georgia, 'Times New Roman', Times, serif");
        $("p").css("font-family", "Georgia, 'Times New Roman', Times, serif");
    });
    $("#segoe").click(function () {
        $("article").css("font-family", "'Segoe UI'");
        $("p").css("font-family", "'Segoe UI'");
    });
    $("#times").click(function () {
        $("article").css("font-family", "'Times New Roman'");
        $("p").css("font-family", "'Times New Roman'");
    });
    $(".maiar").click(function () {
        $("p").css("text-align", "right");
    });
    $(".maiac").click(function () {
        $("p").css("text-align", "justify");
    });
    $(".maiae").click(function () {
        $("p").css("text-align", "left");
    });
    $(".mairc").click(function () {
        $("article").css({ "font-size": "14px", "font-family": "'Segoe UI', Arial, Helvetica, Tahoma, Geneva, Verdana, sans-serif", "line-height": "19px", "text-align": "left" });
        $("p").css({ "font-size": "14px", "font-family": "'Segoe UI', Arial, Helvetica, Tahoma, Geneva, Verdana, sans-serif", "line-height": "19px", "text-align": "left" });
        $("article h1").css("font-size", "30px");
        $("article h2").css("font-size", "27px");
        $("article h3").css("font-size", "25px");
        $("article h4").css("font-size", "20px");
        $("article h5").css("font-size", "16px");
        pFontSize = 14, pH1 = 30, pH2 = 27, pH3 = 25, pH4 = 20, pH5 = 16, pLineHeight = 19;
        pFontFamily = "'Segoe UI', Arial, Helvetica, Tahoma, Geneva, Verdana, sans-serif", pTextAlign = "left";
    });
    $(this).delay(1500).queue(function () { $(".one").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".two").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".three").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".four").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".five").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".six").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".seven").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".eight").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".nine").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".ten").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".eleven").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".twelve").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".thirteen").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".fourteen").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".fifteen").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".sixteen").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".seventeen").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".eighteen").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".nineteen").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".twenty").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".twentyone").addClass("selected"); $(this).dequeue(); })
   .delay(500).queue(function () { $(".twentytwo").addClass("selected"); $(this).dequeue(); });

});
function CountChar(xId, xMax, xDestination) {
    var length = document.getElementById(xId).value.length;
    if (length == 0) {
        document.getElementById(xDestination).innerHTML = "Nenhum caractere inserido.";
    } else if (length == 1) {
        document.getElementById(xDestination).innerHTML = "1 caractere (Max: " + xMax + ").";
    } else if (length >= xMax) {
        document.getElementById(xDestination).innerHTML = length + " caracteres. | <strong>Reduza para " + xMax + " caracteres</strong>";
    } else {
        document.getElementById(xDestination).innerHTML = length + " caracteres (Max: " + xMax + ").";
    }
}

$(window).scroll(function(){
	if($(window).scrollTop() > 80){
		$('.sidebar').css('right','15px');
        $('.sidebar').css('position','fixed');
		$('.sidebar').css('top','15px');
    } else {
		$('.sidebar').css('top','127px');
    }    
});