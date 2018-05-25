﻿$(function () {
    initTable();
});
var $table = $('#table');
function initTable() {
    $table.bootstrapTable({
        url: '/SysAccountInfo/IndexAsync',            //数据来源地址
        method: 'post',                     //数据请求方式
        striped: true,                      //是否显示行间隔色
        cache: false,                       //是否使用缓存，默认为true，所以一般情况下需要设置一下这个属性（*）
        pagination: true,                   //是否启用分页
        sidePagination: 'server',           //在服务器端分页
        queryParams: queryParams,           //传递参数
        pageNumber: 1,                      //初始化加载第一页，默认第一页
        pageSize: 20,                       //每页的记录行数（*）
        pageList: [10, 20, 30, 40, 50],     //可供选择的每页的行数（*）
        clickToSelect: true,                //是否启用点击选中行
        //toolbar: "#tableToolBar",
        height: getHeight(),
        columns: [{
            width: 38,
            field: 'selected',
            checkbox: true,
        }, {
            width: 38,
            title: '行号',
            align: 'center',
            formatter: function (value, row, index) { return index + 1; }
        }, {
            field: 'suName',
            title: '员工名称',
            align: 'center'
        },  {
            field: 'position',
            title: '职位',
            align: 'center'
        }, {
            field: 'role',
            title: '权限',
            align: 'center',
            formatter: operateFormattercommodityType
        }, {
            field: 'phone',
            title: '电话',
            align: 'center'
        }, {
            field: 'identity',
            title: '身份证号',
            align: 'center'
        }, {
            field: 'email',
            title: '邮箱',
            align: 'center'
        },  {
            field: 'login',
            title: '登录名',
            align: 'center'
        }, {
            field: 'lastLoginTime',
            title: '最后登录时间',
            align: 'center'
        }, {
            field: 'id',
            title: '操作',
            align: 'center',
            events: operateEvents,
            formatter: operateFormatter
        }],
        onLoadSuccess: function (data) {
            if (data.total == 0) {
                $(".ibox-content").css("padding-bottom", "22px");
            } else {
                $(".ibox-content").css("padding-bottom", "4px");
            }
        }
    });
}

//查询的参数
var queryParams = function (params) {
    var temp = {
        pageSize: params.limit,                             //行数
        pageIndex: (params.offset / params.limit) + 1,      //页码
        search: $('#searchKey').val()                       //查询内容
    };
    console.info(temp);
    return temp;
};

//刷新表格数据
var refreshTable = function () {
    $table.bootstrapTable('refresh');
}

//自定义的列事件
function operateFormatter(value, row, index) {
    return [
        //'<a class="edit" href="javascript:void(0)" title="编辑" onclick ="editData(' + value + ')" >',
        //'<i class="glyphicon glyphicon-edit"></i>',
        //'</a>  ',
        //'<a class="remove" href="javascript:void(0)"  onclick ="DeletedData(' + value + ')" title="删除">',
        //'<i class="glyphicon glyphicon-remove"></i>',
        //'</a>',
        '<button type="button" class="btn btn-primary btn-sm" onclick ="editData(' + value + ')"  >编辑</button> ',  
        '<button type="button" class="btn btn-danger btn-sm" onclick ="DeletedData(' + value + ')"  >删除</button> ',  
    ].join('');
}

window.operateEvents = {
    'click .edit': function (e, value, row, index) {

    },
    'click .remove': function (e, value, row, index) {

    }
};


function isTrueFormatter(value, row, index) {
    return value ? '<i class="glyphicon glyphicon-ok"></i>' : '<i class="glyphicon glyphicon-remove"></i>'
}

//获取表格高度
function getHeight() {
    return $(window).height() - 150;
}

//重置表格高度
setTimeout(function () {
    $table.bootstrapTable('resetView');
}, 200);

//重置表格高度
$(window).resize(function () {
    $table.bootstrapTable('resetView', {
        height: getHeight()
    });
});

//刷新按钮
$('#refreshBtn').click(function (e) {
    $table.bootstrapTable('refresh');
});

//搜索按钮
$('#searchBtn').click(function (e) {
    $table.bootstrapTable('refresh');
});

//插入按钮弹出窗口
$('#insertBtn').click(function (e) {
    parent.layer.open({
        type: 2,
        title: '添加字典',
        shadeClose: false,
        shade: 0.4,
        area: ['600px', '700px'],
        content: '/SysAccountInfo/Insert',
        end: function () {
            refreshTable();
        }
    });
});

//编辑按钮
$('#editBtn').click(function (e) {
    var selected = $table.bootstrapTable('getSelections');

    if (selected.length > 1) {
        layer.msg("一次只能修改一条数据！", { icon: 5, time: 2000 });
        return;
    }

    if (selected.length == 0) {
        layer.msg("请选择您要修改的数据！", { icon: 5, time: 2000 });
        return;
    }
    editData(selected[0].id);
});

//打开编辑窗口
function editData(id) {
    parent.layer.open({
        type: 2,
        title: '修改账户',
        shadeClose: false,
        shade: 0.4,
        area: ['600px', '700px'],
        content: '/SysAccountInfo/Edit?id=' + id,
        end: function () {
            refreshTable();
        }
    });
}

//删除按钮
$('#deleteBtn').click(function (e) {
    var selected = $table.bootstrapTable('getSelections');
    if (selected.length == 0) {
        layer.msg("请选择您要删除的数据！", { icon: 5, time: 2000 });
        return;
    }

    var arr = [];
    for (var i = 0; i < selected.length; i++) {
        arr.push(selected[i].id);
    }
    var ids = arr.join(",");

    DeletedData(ids);
});

function DeletedData(id) {
    layer.confirm('您确定要删除所选数据吗', {
        btn: ['是的', '取消'] //按钮
    }, function () {
        $.ajax({
            url: "/SysAccountInfo/DeleteAsync",
            type: "post",
            dataType: "json",
            data: { ids: id },
            success: function (data) {
                //Info,Success,Warning,Error
                var type = data.type;
                if (type == 1) {
                    layer.msg(data.content,
                        {
                            icon: 6, time: 2000
                        },
                        function () {
                            refreshTable();
                        });
                } else {
                    layer.msg(data.content, { icon: 5, time: 2000 });
                }
            }
        });
    }, function () {
        return;
    });
};

function operateFormattercommodityType(value, row, index) {
    var v = value;
    return [
        getcommodityType(value),
    ].join('');
}


function getcommodityType(value) {
    if (value == 0) {
        return "超级管理员";
    } else if (value == 1) {
        return "一般管理员";
    } else {
        return "---";
    }
}