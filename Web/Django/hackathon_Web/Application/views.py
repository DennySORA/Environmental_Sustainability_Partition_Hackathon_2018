from django.shortcuts import render
from django.http import HttpResponse
import time
import socket
import ast
import json
import json2html
# Create your views here.


def index(request):
    return render(request, 'index.html')


def about_me(request):
    return render(request, 'html/about_me.html')


def Test(request):
    Data = open(r"D:\資料\VS project\GitHub\hackathon\Web\Django\hackathon_Web\Application\Data.json",
                'r', encoding='utf-8').read()
    Data = ast.literal_eval(Data)
    Data = json2html.json2html.convert(Data).replace("AllGoodsList", "所有折扣").replace("AllMemberList", "所有使用者狀態").replace("Price", "所需點數").replace(
        "GoodsName", "折扣品項").replace("Amount", "折扣剩餘量").replace("Level", "使用權限").replace("MemberGoodsList", "擁有折扣").replace("UserName", "使用者名稱").replace("Point", "擁有點數").replace("table", "table class=\"table table-striped table-hover \"")
    return render(request, 'html/Test.html', {"Main_1": Data})


def intorduc(request):
    return render(request, 'html/intorduc.html')


def idea(request):
    return render(request, 'html/idea.html')