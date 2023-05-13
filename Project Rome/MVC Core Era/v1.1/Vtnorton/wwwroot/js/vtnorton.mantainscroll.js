$(document).scroll(function () {
    localStorage['page'] = document.URL;
    localStorage['scrollTop'] = $(document).scrollTop();
});