<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ContentController extends Controller
{

  public function index(){
      $items = \App\Models\Item::orderBy('created_at', 'desc')->get();
      return view('content.index', compact('items'));
  }

  public function about(){
      return view('other.about');
  }

}
