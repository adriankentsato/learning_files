// check with the user whether he wants to be notified

$('#btnGrantPermission').click(function () {
    if (window.Notifications.checkPermission() == 0) {
        createNotification();
    } else {
        window.Notifications.requestPermission();
    }
});

function createNotification() {
    var notification = window.Notifications.createNotification
                       ("1.png", 
                       "New HTML5 Notification Received - Subject", 
                       "More Content...");
    notification.onshow = function () {
        setTimeout(notification.cancel(), 1500);
    }
    notification.show();
}

<!DOCTYPE html>
<html>
<head>
    <title>Notifications</title>    
    <script type="text/javascript" 

    src="jquery-1.6.2.min.js"></script>
</head>
<body>
    <div>
        <input id="btnGrantPermission" 

        type="button" value="Grant Notification Permission" />
    </div>
    <script type="text/javascript">
        $(document).ready(function () {        
            if (window.webkitNotifications) {
                window.Notifications = window.webkitNotifications;
                $('#btnGrantPermission').click(function () {
                    if (window.Notifications.checkPermission() == 0) {
                        createNotification();
                    } else {
                        window.Notifications.requestPermission();
                    }
                });
            }            
        });        
 
        function createNotification() {
            var notification = window.Notifications.createNotification
            ("1.png", "New HTML5 Notification Received - Subject", 
            "More Content...");
            notification.onshow = function () {
                setTimeout(notification.cancel(), 15000);
            }
            notification.show();
        }
    </script>
</body>
</html>