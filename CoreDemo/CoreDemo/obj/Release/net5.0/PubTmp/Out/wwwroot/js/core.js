$("#btn").click(function () {
    let value = {
        Mail: $("#txtmail").val()
    };

    $.ajax({
        type: "Post",
        url: "/NewsLetter/SubscribeMail/",
        data: value,
        success: function (func) {
            let result = jQuery.parseJSON(func);
        }
    });
});

$("#btnaddcomment").click(function () {
    let value = {
        UserName: $("#txtusername3").val(),
        Title: $("#txttitle3").val(),
        Content: $("#txtcontent3").val(),
        BlogID: $("#txtblogid3").val()
    };

    $.ajax({
        type: "Post",
        url: "/Comment/AddComment/",
        data: value,
        success: function (func) {
            let result = jQuery.parseJSON(func);
        }
    });
});