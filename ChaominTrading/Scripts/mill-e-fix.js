//凌廣表單專用
/*
 method='post' enctype="application/x-www-form-urlencoded" name='form1' id="form1" onsubmit="sendMail(this);"

must="1"
  必要欄位

title="xxxx"
  欄位名稱

default_value="xx"
  預設值


select 內的 option value 要設定

radio 與 checked 同類型要同名稱
*/
function sendMail(self){
    event.returnValue = false;
    var href = "mailto:";
    href += accept(self.accept);
    if (self.subject){
      href += "?subject=" + self.subject.value;
    };
    var body = form_param(self);
    if (body==false)return false;
    if (body!=""){
      href += "&body=" + body;
    };


    window.location.href = href;

    return false;
};

  function accept(self){
    var tmp = "";
    if (self.length){
      for (var idx=0; idx<self.length; idx++){
        tmp = aaa (self.item(idx), tmp);
      };
    } else {
      tmp = aaa (self, tmp);
    };

    function aaa(obj, data){
      if (data != "")data = data + ", ";
      data = data + obj.value;
      return data;
    };
    //alert (tmp);
    return tmp;
  };

  function sim_list(item){
    var _item = item;

    this.name = (item.name)?item.name:item.item(0).name;
    this.type = (item.type)?item.type:item.item(0).type;
    this.value = "";
    if(item.length){
      if (item.item(0).title)this.title = item.item(0).title;
      this.length = item.length;
      if (item.item(0).must)this.must=item.item(0).must;
      if (item.item(0).value)this.value =item.item(0).value;
    } else {
      if (item.title)this.title = item.title;
      this.length = 1;
      if (item.must)this.must=item.must;
      if (item.value)this.value =item.value;
    };

    this.item = function (idx){
      if (_item.length){
        return _item.item(idx);
      } else {
        return _item;
      };
    };

    this.focus = function (){
      if (_item.length){
        _item.item(0).focus();
      } else {
        _item.focus();
      };
    };

    this.select = function (){
      if (_item.length){
        _item.item(0).select();
      } else {
        _item.select();
      };
    };

  };

function form_param(self){
    var tmp = "hidden:IMAGE:OPTION";
    var worked = "";
    var data = "";
    var send_data = "";
    for (var idx=0; idx<self.elements.length; idx++){
      var item = self.elements.item(idx);

      if (worked.indexOf (item.name.toLowerCase()+":", 0) == -1){
        if (tmp.indexOf (item.type.toLowerCase()+":", 0) == -1){
          var item = new sim_list (self.elements.namedItem(item.name));
          switch (item.type.toLowerCase()) {
            case "text" :
              if (item.length > 1){
                alert (item.name + "the name repeating ");
              };
              var obj = item.item(0);
              if (obj.must){
                if ((obj.value=="") || (obj.default_value==item.value)){
                  item.focus();
                  if(item.select)item.select();
                  alert ("Please go back to previous page and make sure to fill in the "+ get_title (item) + " and contact information.");
                  return false;
                };
              };
              if (item.value != ""){
                send_data += value (item, item.value);
              };
              break;

            case "radio" :
              var ok = false;
              for (var j=0; j<item.length; j++){
                var obj = item.item(j);
                if (obj.checked){
                  send_data += value (item, obj.value);
                  ok = true;
                  break;
                };
              };

              if (!ok ){
                item.item(0).focus();
                alert ("Please go back to previous page and make sure to fill in the "+ get_title (item) + " and contact information.");
                return false;
              };
              break;

            case "checkbox" :
              var tmp_data = "";
              for (var j=0; j<item.length; j++){
                var obj = item.item(j);
                if (obj.checked){
                  if (tmp_data!="")tmp_data += '; ';
                  tmp_data += obj.value;
                };
              };
              if (item.must && (tmp_data=="")){
                item.focus();
                if(item.select)item.select();
               alert ("Please go back to previous page and make sure to fill in the "+ get_title (item) + " and contact information.");
                return false;
              };
              send_data += value (item, tmp_data);
              break;

            case "select-one" :
              var item = item.item(0).parentElement;
              var tmp_idx = item.selectedIndex;
              if (item.must){
                if ((item.default_value==tmp_idx)){
                  item.focus();
                  if(item.select)item.select();
                  alert ("Please go back to previous page and make sure to fill in the "+ get_title (item) + " and contact information.");
                  return false;
                };
              };
  //            send_data += value (item, item.options.item(tmp_idx).innerHTML);
              send_data += value (item, item.value);
              break;

          case "textarea" :
             var obj = item.item(0);
              if (obj.must){
                if ((obj.value=="") || (obj.default_value==item.value)){
                  item.focus();
                  if(item.select)item.select();
                  alert ("Please go back to previous page and make sure to fill in the "+ get_title (item) + " and contact information.");
                  return false;
                };
              };
//              if (item.value != ""){
                send_data += value (item, item.value);
  //            };
              break;
            break;
          }
          //data = data + item.item(0).name + ":" + item.item(0).type + ":" + item.item(0).value + '\n\r';
        }

        worked += item.name.toLowerCase() + ":";
      }

	};
    return send_data;



    function value(obj, data){
//      return "[" + get_title (item) + "/" + item.type + "]ï¿½G" + data + '%0A%0A';
      return "[" + get_title (item) + "]：" + data + '%0A%0A';
    };

    function get_title(obj){
      if (obj.title)return obj.title;
      return obj.name;
    };
};


  // function window.onload(){
  //   // var obj = form1.elements("Shelf");
  //   //alert (obj.length);
  // };

