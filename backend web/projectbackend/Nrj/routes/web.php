<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\PostController;
use App\Http\Controllers\LikeController;
use App\Http\Controllers\UserController;
use App\Http\Controllers\AdminController;
use App\Http\Controllers\FaqController;
use App\Http\Controllers\FaqCategoryController;



/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/',[PostController::class,'index'])->name('index');

Route::resource('posts', PostController::class);

Route::get('like/{postid}', [LikeController::class, 'like'])->name('like');
Route::get('user/{name}',   [UserController::class, 'profile'])->name('profile');
Route::put('/profile/{name}', [UserController::class, 'update'])->name('profile.update');



// FAQ page
Route::get('/faq', [FaqController::class, 'index'])->name('faq.index');
Route::post('/faq', [FaqController::class, 'store'])->name('faq.store');
Route::get('/faq-categories', [FaqController::class, 'showCategories'])->name('faq.categories');


// FAQ administration
Route::prefix('admin/faq')->middleware('admin')->group(function () {
    Route::resource('categories', FaqCategoryController::class)->except(['show'])->names([
        'index' => 'admin.categories.index',
        // ...
    ]);

 });


Route::get('/admin/categories', [AdminController::class, 'categoriesIndex'])->name('admin.categories.index');
Route::get('/admin/pairs', [AdminController::class, 'pairsIndex'])->name('admin.pairs.index');

Route::middleware('admin')->prefix('admin')->group(function () {
    Route::get('users', [AdminController::class, 'showUsers'])->name('admin.users');
    Route::get('users/{id}', [AdminController::class, 'showUser'])->name('admin.users.show');
    Route::post('users/{id}/promote', [AdminController::class, 'promoteUser'])->name('admin.users.promote');
    Route::post('/admin/users/{id}/demote', [AdminController::class, 'demoteUser'])->name('admin.users.demote');
    Route::group(['middleware' => 'admin'], function () {
    // Routes die alleen toegankelijk zijn voor admins
});

});



Auth::routes();

Route::get('/home', [App\Http\Controllers\HomeController::class, 'index'])->name('home');


