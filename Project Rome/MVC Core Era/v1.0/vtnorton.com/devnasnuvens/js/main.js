function init_map() {
    var e = {
        zoom: 14, center:
            new google.maps.LatLng(-20.3171903, -40.3253421), mapTypeId: google.maps.MapTypeId.ROADMAP, scrollwheel: !1, styles: [{ featureType: "all", stylers: [{ saturation: -100 }, { gamma: .5 }] }]
    }; map = new google.maps.Map(document.getElementById("gmap_canvas"), e),
    marker = new google.maps.Marker({
        map: map, position:
            new google.maps.LatLng(-20.3171903, -40.3253421)
    }), infowindow = new google.maps.InfoWindow({
        content: "<b>#DevNasNuvens 2016</b><br/>Faculdade Catolica Salesiana do Espirito Santo"
    }), google.maps.event.addListener(marker, "click", function () {
        infowindow.open(map, marker)
    }), infowindow.open(map, marker)
} jQuery(document).ready(function (e) {
    "use strict"; function a(a) {
        var i = this.currentItem; e("#days").find(".owl-item").removeClass("synced").eq(i).addClass("synced"), void 0 !== e("#days").data("owlCarousel") && o(i)
    } function o(e) {
        var a = t.data("owlCarousel").owl.visibleItems, o = e, i = !1;
        for (var n in a) if (o === a[n]) var i = !0; i === !1 ? o > a[a.length - 1] ? t.trigger("owl.goTo", o - a.length + 2) : (o - 1 === -1 && (o = 0), t.trigger("owl.goTo", o)) : o === a[a.length - 1] ? t.trigger("owl.goTo", a[1]) : o === a[0] && t.trigger("owl.goTo", o - 1)
    } smoothScroll.init({
        speed: 500, easing: "easeInOutCubic", updateURL: !1, callbackBefore: function (e, a) { },
        callbackAfter: function (e, a) { }
    }), e("#countdown").countdown({ until: new Date("August 27, 2016 13:00:00") }), e(".timer").countTo(),
    e(".speaker-detail").magnificPopup({ type: "ajax" }), e(".register").magnificPopup({ type: "ajax" }),
    e(".image-link").magnificPopup({ type: "image" }); var i = e("#timetable"), n = e("#timetable2"), t =
        e("#days"); i.owlCarousel({
            singleItem: !0, slideSpeed: 1e3, navigation: !1, pagination: !1, afterAction: a,
            responsiveRefreshRate: 200
        }), n.owlCarousel({
            singleItem: !0, slideSpeed: 1e3, navigation: !1, pagination: !1, afterAction: a,
            responsiveRefreshRate: 200
        }), t.owlCarousel({
            items: 4, itemsMobile: [479, 4], pagination: !1, responsiveRefreshRate: 100, afterInit:
                function (e) { e.find(".owl-item").eq(0).addClass("synced") }
        }), e("#days").on("click", ".owl-item", function (a) {
            a.preventDefault(); var o = e(this).data("owlItem");
            i.trigger("owl.goTo", o)
        }); var l = e(".gallery"); l.owlCarousel({ itemsCustom: [[0, 2], [450, 2], [600, 4], [700, 4], [1e3, 4], [1200, 4], [1600, 4]], navigation: !0, navigationText: ['<i class="fa fa-4x fa-chevron-circle-left"></i>', '<i class="fa fa-4x  fa-chevron-circle-right"></i>'] }), e("#quote").owlCarousel({ pagination: !1, slideSpeed: 300, paginationSpeed: 400, singleItem: !0, navigation: !0, navigationText: ['<i class="fa fa-3x fa-chevron-circle-left"></i>', '<i class="fa fa-3x  fa-chevron-circle-right"></i>'] })
}),


$(window).load(function () {
    $(window).stellar({ horizontalScrolling: !1 }), $("#preload").delay(350).fadeOut("slow"),
    $(window).scroll(function () {
        $(".navbar").offset().top > 50 ?
            $(".navbar-fixed-top").addClass("top-nav-collapse") : $(".navbar-fixed-top").removeClass("top-nav-collapse")
    })
}),


google.maps.event.addDomListener(window, "load", init_map);