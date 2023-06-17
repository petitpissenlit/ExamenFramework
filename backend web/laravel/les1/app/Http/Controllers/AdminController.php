<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class AdminController extends Controller
{
  public function edit(){
      return view('admin.edit');
  }

  public function create() {
      return view('admin.create');
  }

  public function store(Request $request){

    $validated = $request->validate([
      'title' => 'required|min:5',
      'content' => 'required',
    ]);

    $title = $request->input('title');
    $content = $request->input('content');

    $item = new \App\Models\Item;
    $item->title = $title;
    $item->content = $content;
    $item->save();

    return redirect()->route('admin.index')
            ->with('type', 'Succes')
            ->with('message', 'Nieuw bericht aangemaakt met titel '. $title);

  }

  public function adminIndex() {
      return view('admin.admin-index');
  }
}
