<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Post;

class PostController extends Controller
{
    public function index(){

        $posts = Post::all();
        return view('posts.index', compact('posts'));
    }

   public function create()
{
    return view('posts.new-post');
}
}
